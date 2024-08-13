namespace assignment2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            addInVoiceToolStripMenuItem = new ToolStripMenuItem();
            addInvoiceToolStripMenuItem1 = new ToolStripMenuItem();
            managersInvoiceToolStripMenuItem = new ToolStripMenuItem();
            managerInvoice = new ManagerInvoice();
            addInvoice = new AddInvoice();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addInVoiceToolStripMenuItem, managersInvoiceToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // addInVoiceToolStripMenuItem
            // 
            addInVoiceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addInvoiceToolStripMenuItem1 });
            addInVoiceToolStripMenuItem.Name = "addInVoiceToolStripMenuItem";
            addInVoiceToolStripMenuItem.Size = new Size(99, 24);
            addInVoiceToolStripMenuItem.Text = "AddInVoice";
            addInVoiceToolStripMenuItem.Click += addInVoiceToolStripMenuItem_Click;
            // 
            // addInvoiceToolStripMenuItem1
            // 
            addInvoiceToolStripMenuItem1.Name = "addInvoiceToolStripMenuItem1";
            addInvoiceToolStripMenuItem1.Size = new Size(171, 26);
            addInvoiceToolStripMenuItem1.Text = "Add Invoice";
            // 
            // managersInvoiceToolStripMenuItem
            // 
            managersInvoiceToolStripMenuItem.Name = "managersInvoiceToolStripMenuItem";
            managersInvoiceToolStripMenuItem.Size = new Size(139, 24);
            managersInvoiceToolStripMenuItem.Text = "Manager Invoices";
            managersInvoiceToolStripMenuItem.Click += managersInvoiceToolStripMenuItem_Click;
            // 
            // managerInvoice
            // 
            managerInvoice.Location = new Point(0, 31);
            managerInvoice.Name = "managerInvoice";
            managerInvoice.Size = new Size(800, 598);
            managerInvoice.TabIndex = 1;
            // 
            // addInvoice
            // 
            addInvoice.Location = new Point(0, 31);
            addInvoice.Name = "addInvoice";
            addInvoice.Size = new Size(800, 598);
            addInvoice.TabIndex = 2;
            addInvoice.Load += addInvoice1_Load;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 626);
            Controls.Add(addInvoice);
            Controls.Add(managerInvoice);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem addInVoiceToolStripMenuItem;
        private ToolStripMenuItem addInvoiceToolStripMenuItem1;
        private ToolStripMenuItem managersInvoiceToolStripMenuItem;
        private ManagerInvoice managerInvoice;
        private AddInvoice addInvoice;
    }
}
