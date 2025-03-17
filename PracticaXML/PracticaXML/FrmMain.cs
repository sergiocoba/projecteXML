using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace PracticaXML
{
    public partial class FrmMain : Form
    {
        private OpenFileDialog openFileDialog;
        static XPathDocument document;
        XPathNavigator navegador;

        XmlDocument xDoc;
        XmlNode xNodeArrel;
        XmlDeclaration xDeclaracio;
        XmlComment xComentari;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos XML (*.xml)|*.xml";
            openFileDialog.Title = "Seleccione un archivo XML";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                document = new XPathDocument(openFileDialog.FileName);
                tbArchivo.Text = openFileDialog.FileName;
                navegador = document.CreateNavigator();
            }
            rbDepartament.Checked = true;
        }


        private void omplirComboBox(int opcio)
        {
            XPathNodeIterator cursor = null;
            XPathExpression expr = navegador.Compile("//row//row");

            expr.AddSort("obsequi", XmlSortOrder.Ascending, XmlCaseOrder.None, "", XmlDataType.Text);
            llObsequis.Items.Clear();
            cursor = navegador.Select(expr);

            List<string> obsequisExistents = new List<string>();
            List<string> categoriaExistents = new List<string>();
            List<string> departamentExistents = new List<string>();
            List<string> unitatsExistents = new List<string>();


            if (opcio == 0)
            {
                comboBox.Items.Clear();

                foreach (XPathNavigator tut in cursor)
                {
                    string categoria = tut.SelectSingleNode("categor_a_obsequi").Value.ToString();
                    if (!categoriaExistents.Contains(categoria))
                    {
                        comboBox.Items.Add(categoria);
                        categoriaExistents.Add(categoria);
                    }

                }
        
                comboBox.SelectedIndex = 0;
            }
            else if (opcio == 1)
            {
                comboBox.Items.Clear();
                foreach (XPathNavigator tut in cursor)
                {
                    string departament = tut.SelectSingleNode("departament").Value.ToString();
                    if (!departamentExistents.Contains(departament))
                    {
                        comboBox.Items.Add(departament);
                        departamentExistents.Add(departament);
                    }
                }
                comboBox.SelectedIndex = 0;
            }
            else if (opcio == 2)
            {
                comboBox.Items.Clear();
                foreach (XPathNavigator tut in cursor)
                {
                    string unitat = tut.SelectSingleNode("unitat_org_nica").Value.ToString();
                    if (!unitatsExistents.Contains(unitat))
                    {
                        comboBox.Items.Add(unitat);
                        unitatsExistents.Add(unitat);
                    }
                }
                comboBox.SelectedIndex = 0;
            }
            
        }

        
        private void omplirListBox(int opcio)
        {
            XPathNodeIterator cursor = null;
            XPathExpression expr = navegador.Compile("//row//row");
            expr.AddSort("obsequi", XmlSortOrder.Ascending, XmlCaseOrder.None, "", XmlDataType.Text);
            llObsequis.Items.Clear();
            cursor = navegador.Select(expr);

            List<string> obsequisExistents = new List<string>();
            List<string> categoriaExistents = new List<string>();
            int dataMax = 0;
            int dataMin = 2024;

            if (opcio == 0)
            {
                foreach (XPathNavigator tut in cursor)
                {
                    string obsequi = tut.SelectSingleNode("obsequi").Value.ToString();
                    if (tut.SelectSingleNode("categor_a_obsequi").Value.ToString() == comboBox.SelectedItem.ToString() && !obsequisExistents.Contains(obsequi))
                    {
                        llObsequis.Items.Add(obsequi);
                        obsequisExistents.Add(obsequi);
                    }
                }
            }
            else if (opcio == 1)
            {
                foreach (XPathNavigator tut in cursor)
                {
                    string obsequi = tut.SelectSingleNode("obsequi").Value.ToString();
                    if (tut.SelectSingleNode("departament").Value.ToString() == comboBox.SelectedItem.ToString() && !obsequisExistents.Contains(obsequi))
                    {
                        llObsequis.Items.Add(obsequi);
                        obsequisExistents.Add(obsequi);
                    }
                }
            }
            else if (opcio == 2)
            {
                foreach (XPathNavigator tut in cursor)
                {
                    string obsequi = tut.SelectSingleNode("obsequi").Value.ToString();
                    if (tut.SelectSingleNode("unitat_org_nica").Value.ToString() == comboBox.SelectedItem.ToString() && !obsequisExistents.Contains(obsequi))
                    {
                        llObsequis.Items.Add(obsequi);
                        obsequisExistents.Add(obsequi);
                    }
                }
            }


        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rbCategoria.Checked)
            {
                omplirListBox(0);
            }
            else if (rbDepartament.Checked)
            {
                omplirListBox(1);
            }
            else if (rbUnitat.Checked)
            {
                omplirListBox(2);
            }

        }

        private void rbCategoria_CheckedChanged(object sender, EventArgs e)
        {
            string op = ((RadioButton)(sender)).Name;
            switch (op)
            {
                case "rbCategoria":
                    omplirComboBox(0);
                    break;
                case "rbDepartament":
                    omplirComboBox(1);
                    break;
                case "rbUnitat":
                    omplirComboBox(2);
                    break;
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            dgvObsequis.Rows.Clear();

            if (rbDepartament.Checked == true)
            {
                while (i < llObsequis.SelectedItems.Count)
                {
                    string obsequi = llObsequis.SelectedItems[i].ToString();

                    obtenirDadesObsequisPerDep(obsequi, dateDesde.Value, dateFins.Value);
                    i++;
                }
            }
            else if (rbUnitat.Checked == true)
            {
                while (i < llObsequis.SelectedItems.Count)
                {
                    string obsequi = llObsequis.SelectedItems[i].ToString();

                    obtenirDadesObsequisPerUnidad(obsequi, dateDesde.Value, dateFins.Value);
                    i++;
                }
            }
            else
            {
                while (i < llObsequis.SelectedItems.Count)
                {
                    string obsequi = llObsequis.SelectedItems[i].ToString();

                    obtenirDadesObsequis(obsequi, dateDesde.Value,dateFins.Value);
                    i++;
                }
            }

           
        }

        private void obtenirDadesObsequisPerUnidad(string m, DateTime dataMin, DateTime dataMax)
        {
            XPathNodeIterator cursor = null;
            XPathExpression expr = navegador.Compile("//row//row");

            expr.AddSort("obsequi", XmlSortOrder.Ascending, XmlCaseOrder.None, "", XmlDataType.Text);
            cursor = navegador.Select(expr);


            foreach (XPathNavigator tut in cursor)
            {
                string obsequi = tut.SelectSingleNode("obsequi").Value;
                DateTime fecha = DateTime.Parse(tut.SelectSingleNode("data").Value.ToString());
                string unidad = tut.SelectSingleNode("unitat_org_nica").Value;

                if (obsequi == m && fecha >= dataMin && fecha <= dataMax && unidad == comboBox.Text.Trim())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvObsequis);
                    row.Cells[0].Value = tut.SelectSingleNode("departament").Value;
                    row.Cells[1].Value = obsequi;
                    row.Cells[2].Value = fecha;
                    row.Cells[3].Value = tut.SelectSingleNode("lliurat_per").Value;
                    row.Cells[4].Value = tut.SelectSingleNode("rebut_per").Value;
                    row.Cells[5].Value = tut.SelectSingleNode("destinat_a").Value;

                    dgvObsequis.Rows.Add(row);


                }
            }
        }

        private void obtenirDadesObsequis(string m, DateTime dataMin,DateTime dataMax)
        {
            XPathNodeIterator cursor = null;
            XPathExpression expr = navegador.Compile("//row//row");

            expr.AddSort("obsequi", XmlSortOrder.Ascending, XmlCaseOrder.None, "", XmlDataType.Text);
            cursor = navegador.Select(expr);

            foreach (XPathNavigator tut in cursor)
            {
                string obsequi = tut.SelectSingleNode("obsequi").Value;
                DateTime fecha = DateTime.Parse(tut.SelectSingleNode("data").Value.ToString());


                if (obsequi == m && fecha >= dataMin && fecha<=dataMax)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvObsequis);
                    row.Cells[0].Value = tut.SelectSingleNode("departament").Value;
                    row.Cells[1].Value = obsequi;
                    row.Cells[2].Value = fecha;
                    row.Cells[3].Value = tut.SelectSingleNode("lliurat_per").Value;
                    row.Cells[4].Value = tut.SelectSingleNode("rebut_per").Value;
                    row.Cells[5].Value = tut.SelectSingleNode("destinat_a").Value;

                    dgvObsequis.Rows.Add(row);

                    
                }
            }
        } 
        
        private void obtenirDadesObsequisPerDep(string m, DateTime dataMin, DateTime dataMax)
        {
            XPathNodeIterator cursor = null;
            XPathExpression expr = navegador.Compile("//row//row");

            expr.AddSort("obsequi", XmlSortOrder.Ascending, XmlCaseOrder.None, "", XmlDataType.Text);
            cursor = navegador.Select(expr);

            
            foreach (XPathNavigator tut in cursor)
            {
                string obsequi = tut.SelectSingleNode("obsequi").Value;
                DateTime fecha = DateTime.Parse(tut.SelectSingleNode("data").Value.ToString());
                string dep = tut.SelectSingleNode("departament").Value;

                if (obsequi == m && fecha >= dataMin && fecha <= dataMax && dep == comboBox.Text.Trim())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvObsequis);
                    row.Cells[0].Value = tut.SelectSingleNode("departament").Value;
                    row.Cells[1].Value = obsequi;
                    row.Cells[2].Value = fecha;
                    row.Cells[3].Value = tut.SelectSingleNode("lliurat_per").Value;
                    row.Cells[4].Value = tut.SelectSingleNode("rebut_per").Value;
                    row.Cells[5].Value = tut.SelectSingleNode("destinat_a").Value;
                   
                    dgvObsequis.Rows.Add(row);


                }
            }
        }

        private void btObsequis_Click(object sender, EventArgs e)
        {
            dlg.InitialDirectory = Application.StartupPath;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.File.Exists(dlg.FileName))
                {
                    System.IO.File.Delete(dlg.FileName);
                }
                iniFitxerXML("Obsequis rebuts per alts carrecs","Obsequis");
                consultaGenericaTitol(0);
                fiFitxerXML("Fi de la llista");
            }
            

        }
        private void fiFitxerXML(String xcomentari)
        {
            xComentari = xDoc.CreateComment(xcomentari);
            xDoc.InsertAfter(xComentari, xNodeArrel);

            if (!dlg.FileName.ToLower().EndsWith(".xml"))
            {
                dlg.FileName += ".xml";
            }
            xDoc.Save(dlg.FileName);
        }
        private void iniFitxerXML(String xcomentari,string element)
        {
            xDoc = new XmlDocument();

            xDeclaracio = xDoc.CreateXmlDeclaration("1.0", "utf-8", "yes");
            xDoc.InsertBefore(xDeclaracio, xDoc.DocumentElement);

            xComentari = xDoc.CreateComment(xcomentari);
            xDoc.InsertAfter(xComentari, xDeclaracio);
            
            xNodeArrel = xDoc.CreateElement(element);
            xDoc.AppendChild(xNodeArrel);

        }

        private void consultaGenericaTitol(int op)
        {
            XPathNodeIterator cursor = null;
            XPathExpression expr = navegador.Compile("//row//row");

            expr.AddSort("obsequi", XmlSortOrder.Ascending, XmlCaseOrder.None, "", XmlDataType.Text);
            cursor = navegador.Select(expr);


            foreach (XPathNavigator tut in cursor)
            {
                afegirNodesXML(cursor,op);
                  
            }
        }

        private void afegirNodesXML(XPathNodeIterator xpn, int op)
        {
            String obsequi = "";
            String departament = "";
            String unitat = "";

            XmlNode xmlNode = null;
            XmlElement xmlElement = null;
            List<string> obsequisExistents = new List<string>();
            List<string> departamentsExistents = new List<string>();
            List<string> unitatsExistents = new List<string>();



            while (xpn.MoveNext())
            {
                if (op == 0)
                {

                    obsequi = xpn.Current.SelectSingleNode("obsequi").Value.ToString();

                    if (!obsequisExistents.Contains(obsequi))
                    {
                        xmlElement = xDoc.CreateElement("obsequi");
                        xmlElement.InnerText = obsequi;
                        xNodeArrel.AppendChild(xmlElement);
                        obsequisExistents.Add(obsequi);

                    }
                }
                else if (op == 1)
                {

                    departament = xpn.Current.SelectSingleNode("departament").Value.ToString();

                    if (!departamentsExistents.Contains(departament))
                    {
                        xmlElement = xDoc.CreateElement("departament");
                        xmlElement.InnerText = departament;
                        xNodeArrel.AppendChild(xmlElement);
                        departamentsExistents.Add(departament);

                    }
                }
                else if (op == 2)
                {
                    departament = xpn.Current.SelectSingleNode("departament").Value.ToString();
                    unitat = xpn.Current.SelectSingleNode("unitat_org_nica").Value.ToString();

                    XmlElement departamentElement = null;

                    foreach (XmlNode node in xNodeArrel.ChildNodes)
                    {
                        if (node.Name == "departament" && node.Attributes["nom"].Value == departament)
                        {
                            departamentElement = (XmlElement)node;
                            break;
                        }
                    }

                    if (departamentElement == null)
                    {
                        departamentElement = xDoc.CreateElement("departament");
                        departamentElement.SetAttribute("nom", departament);
                        xNodeArrel.AppendChild(departamentElement);
                        departamentsExistents.Add(departament);
                    }

                    bool unitatExisteix = false;
                    foreach (XmlNode node in departamentElement.ChildNodes)
                    {
                        if (node.Name == "unitat_organica" && node.InnerText == unitat)
                        {
                            unitatExisteix = true;
                            break;
                        }
                    }

                    if (!unitatExisteix)
                    {
                        XmlElement unitatElement = xDoc.CreateElement("unitat_organica");
                        unitatElement.InnerText = unitat;
                        departamentElement.AppendChild(unitatElement);
                        unitatsExistents.Add(unitat);
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dlg.InitialDirectory = Application.StartupPath;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.File.Exists(dlg.FileName))
                {
                    System.IO.File.Delete(dlg.FileName);
                }
                iniFitxerXML("Departaments","Departaments");
                consultaGenericaTitol(1);
                fiFitxerXML("Fi de la llista");
            }
        }

        private void btUnitat_Click(object sender, EventArgs e)
        {
            dlg.InitialDirectory = Application.StartupPath;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.File.Exists(dlg.FileName))
                {
                    System.IO.File.Delete(dlg.FileName);
                }
                iniFitxerXML("Unitats Organiques", "Unitats_Organiques");
                consultaGenericaTitol(2);
                fiFitxerXML("Fi de la llista");
            }
        }
    }
}
