using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ
{
    public partial class Form1 : Form
    {
        StudentDataContext db;
        //make generic list
        List<Student> stlist; //list type variable
        int index_no = 0; //make 1 variable
        //now goto line26

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            //now make Object data context
            StudentDataContext st = new StudentDataContext();
         //now write table and move to next line below it and see the small arrow and select system.linq
   
            Table<Student> std = st.Students;
            //display std in datagridview
        //   DataGridView.DataSource = std;
            */


            //object initialization[line 16 to 20]
            db = new StudentDataContext();
            stlist = db.Students.ToList();
            Display();   //made method below and then used here

            Student ss = new Student();
            ss.Id= 9;
            ss.name = "roshi";
            ss.gender = "f";
            db.Students.InsertOnSubmit(ss);
            db.SubmitChanges();

        }

        //make 1 private method
        private void Display()
        {
            //now use Textbox
            ID.Text = stlist[index_no].Id.ToString();           //ID was made in form.cs //index no has value 0
            NAMEtextbox.Text = stlist[index_no].name;
            AGEtextbox.Text = stlist[index_no].age.ToString();
            GENDERtextbox.Text = stlist[index_no].gender;
            CLASStextbox.Text = stlist[index_no].standard.ToString();
        
            //now run console and go to form1.cs[Design]
        }
    private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
