using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Store
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        db db = new db();
        private void register(prd i)
        {
            
            if (i.number >0 && i.price>0)
            {
                //if (checkInput(i.name))
                //{
                //    var q = db.store.Where(x => x.id== i.id).SingleOrDefault();
                //}
                //else
                //{
                //    db.store.Add(new prd { name = i.name, number = i.number, price = i.price });
                //    db.SaveChanges();
                //    dataGridView1.DataSource = db.store.ToList();
                //}
            }
                
        }
        private void update(prd i)
        {
            if (checkInput(i.name))
            {
                var q = db.store.Where(x => x.id == i.id).SingleOrDefault();
            }
        }

       

        public bool checkInput(String name)
        {
           var q = (from i in db.store where i.name == name select i);
            if(q != null) { return true; }
            else return false;
        }

        public void search(string s)
        {

            // usage of Linq

            List<prd> S_list = new List<prd>();
            foreach (prd i in db.store)
            {
                if (i.name.Contains(s))
                {
                    S_list.Add(i);
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = from x in db.store where x.name.Contains(s) select x;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            register(new prd { name = textBox1.Text, number = Convert.ToInt16(textBox2.Text), price = Convert.ToDouble(textBox3.Text) });

            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            search(textBox4.Text);
            
        }
    }
}
