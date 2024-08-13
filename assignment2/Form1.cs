namespace assignment2
{
    public partial class Form1 : Form
    {
        public Invoice invoiceManager;
        public Form1()
        {
            InitializeComponent();
            invoiceManager = new Invoice();

            addInvoice.InvoiceManager = invoiceManager;
            managerInvoice.InvoiceManager = invoiceManager;

            addInvoice.Show();
            managerInvoice.Hide();
        }

        private void addInvoice1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void managersInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            managerInvoice.Show();
            addInvoice.Hide();
            managerInvoice.RefreshInvoiceList(); 
        }

        private void addInVoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            managerInvoice.Hide();
            addInvoice.Show(); 
        }
    } 
}
