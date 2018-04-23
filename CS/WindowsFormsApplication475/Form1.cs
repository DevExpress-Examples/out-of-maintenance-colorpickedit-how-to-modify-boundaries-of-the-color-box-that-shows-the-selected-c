using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication475 {
    public partial class Form1 : Form {
        RepositoryItemCustomEdit edit;
        public Form1() {
            InitializeComponent();
            edit = new RepositoryItemCustomEdit();
            List<Employee> lst = new List<Employee>();
            for (int i = 0; i < 10; i++) {
                lst.Add(new Employee() { ID = i, FirstName = "Name " + i, BirthDate = DateTime.Now, AtVacation = i % 2 == 0, FavoriteColor = Color.Red });
            }
            gridControl1.DataSource = lst;
            gridView1.Columns["FavoriteColor"].ColumnEdit = edit;
        }
    }


    public class Employee {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public bool AtVacation { get; set; }
        public DateTime BirthDate { get; set; }
        public Color FavoriteColor { get; set; }
    }

}
