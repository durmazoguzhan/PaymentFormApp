using System.Data;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Reflection;

namespace OdemeFormApp
{
    public partial class Form1 : Form
    {
        string tur = "";
        private IOdemeTipi odemeTipi;

        ////sql server authentication 
        //SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\okul;Initial Catalog=InveonDB;User Id=sa; Password=123;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        //windows authentican
        SqlConnection conn2 = new SqlConnection(@"Server=(localdb)\inveon;Database=InveonDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (txtTutar.Text.Trim().Length == 0)
            {
                MessageBox.Show("lütfen tutar yazınız...");
            }
            else
            {
                double tutar = Convert.ToDouble(txtTutar.Text);

                OdemeIslemiFactory factory = new OdemeIslemiFactory();
                odemeTipi = factory.GetInstance(tur);
                lblSonuc.Text = odemeTipi.Ode(tutar);

            }
        }

        private void cmbPaymentTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            tur = cmbPaymentTypes.SelectedValue.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigureItems();
            ConfigureClasses();
        }

        public void ConfigureItems()
        {
            try
            {
                conn2.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM OdemeYontemleri", conn2);
                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                cmbPaymentTypes.Items.Clear();
                cmbPaymentTypes.DataSource = dt;
                cmbPaymentTypes.DisplayMember = "DisplayMember";
                cmbPaymentTypes.ValueMember = "DisplayValue";
                reader.Close();
                conn2.Close();
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            
        }

        public void ConfigureClasses()
        {
            foreach (DataRowView item in cmbPaymentTypes.Items)
            {
                string itemValue = item.Row[2].ToString();

                if (!HasClass(itemValue))
                    CreateClass(itemValue);

            }
        }

        public bool HasClass(string className)
        {
            return Type.GetType("OdemeFormApp." + className) == null ? false : true;
        }

        public void CreateClass(string className)
        {
            // bellekte yer ayırma
            AssemblyBuilder assembly = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName(className), AssemblyBuilderAccess.Run);
            ModuleBuilder module = assembly.DefineDynamicModule(className);

            // class tanımlama
            TypeBuilder newClass = module.DefineType(className, TypeAttributes.Public);

            // interface implemente etme
            //newClass.AddInterfaceImplementation(typeof(IOdemeTipi));

            // method oluşturma - override etme


            // class oluşturma
            newClass.CreateType();
        }
    }
}