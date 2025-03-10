﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace PracticaXML
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog;
        static XPathDocument document;
        XPathNavigator navegador;

        XmlDocument xDoc;
        XmlNode xNodeArrel;
        XmlDeclaration xDeclaracio;
        XmlComment xComentari;
        public Form1()
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
                //consultaObsequis(0);
            }
        }


        private void omplirComboBox(int opcio)
        {
            XPathNodeIterator cursor = null;
            XPathExpression expr = navegador.Compile("//row//row");

            expr.AddSort("obsequi", XmlSortOrder.Ascending, XmlCaseOrder.None, "", XmlDataType.Text);
            llMunicipis.Items.Clear();
            cursor = navegador.Select(expr);

            List<string> obsequisExistents = new List<string>();
            List<string> categoriaExistents = new List<string>();
            List<string> departamentExistents = new List<string>();
            List<string> unitatsExistents = new List<string>();



            int dataMax = 0;
            int dataMin = 2024;
            if (opcio == 0)
            {
                comboBox.Items.Clear();

                foreach (XPathNavigator tut in cursor)
                {
                    //if (Int32.Parse(tut.SelectSingleNode("any").Value.ToString()) > dataMax) dataMax = Int32.Parse(tut.SelectSingleNode("any").Value.ToString());

                    //if (Int32.Parse(tut.SelectSingleNode("any").Value.ToString()) < dataMin) dataMin = Int32.Parse(tut.SelectSingleNode("any").Value.ToString());


                    string categoria = tut.SelectSingleNode("categor_a_obsequi").Value.ToString();
                    if (!categoriaExistents.Contains(categoria))
                    {
                        comboBox.Items.Add(categoria);
                        categoriaExistents.Add(categoria);
                    }

                }
                nupAny.Maximum = dataMax;
                nupAny.Minimum = dataMin;
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
            llMunicipis.Items.Clear();
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
                        llMunicipis.Items.Add(obsequi);
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
                        llMunicipis.Items.Add(obsequi);
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
                        llMunicipis.Items.Add(obsequi);
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
    }
}
