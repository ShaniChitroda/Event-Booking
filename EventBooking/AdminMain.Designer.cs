namespace EventBooking
{
    partial class AdminMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            usersToolStripMenuItem = new ToolStripMenuItem();
            addUsersToolStripMenuItem = new ToolStripMenuItem();
            removeUsersToolStripMenuItem = new ToolStripMenuItem();
            viewTotalUsersToolStripMenuItem = new ToolStripMenuItem();
            eventsToolStripMenuItem = new ToolStripMenuItem();
            eventsToolStripMenuItem1 = new ToolStripMenuItem();
            viewEventsToolStripMenuItem = new ToolStripMenuItem();
            addEventToolStripMenuItem = new ToolStripMenuItem();
            removeEventsToolStripMenuItem = new ToolStripMenuItem();
            bookingToolStripMenuItem = new ToolStripMenuItem();
            viewTotalBookingsToolStripMenuItem = new ToolStripMenuItem();
            bookAnEventToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLightLight;
            menuStrip1.Items.AddRange(new ToolStripItem[] { usersToolStripMenuItem, eventsToolStripMenuItem, bookingToolStripMenuItem, logOutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addUsersToolStripMenuItem, removeUsersToolStripMenuItem, viewTotalUsersToolStripMenuItem });
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(47, 20);
            usersToolStripMenuItem.Text = "Users";
            // 
            // addUsersToolStripMenuItem
            // 
            addUsersToolStripMenuItem.Name = "addUsersToolStripMenuItem";
            addUsersToolStripMenuItem.Size = new Size(180, 22);
            addUsersToolStripMenuItem.Text = "Add users";
            // 
            // removeUsersToolStripMenuItem
            // 
            removeUsersToolStripMenuItem.Name = "removeUsersToolStripMenuItem";
            removeUsersToolStripMenuItem.Size = new Size(180, 22);
            removeUsersToolStripMenuItem.Text = "Remove users";
            // 
            // viewTotalUsersToolStripMenuItem
            // 
            viewTotalUsersToolStripMenuItem.Name = "viewTotalUsersToolStripMenuItem";
            viewTotalUsersToolStripMenuItem.Size = new Size(180, 22);
            viewTotalUsersToolStripMenuItem.Text = "View total users";
            // 
            // eventsToolStripMenuItem
            // 
            eventsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { eventsToolStripMenuItem1, viewEventsToolStripMenuItem, addEventToolStripMenuItem, removeEventsToolStripMenuItem });
            eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            eventsToolStripMenuItem.Size = new Size(53, 20);
            eventsToolStripMenuItem.Text = "Events";
            // 
            // eventsToolStripMenuItem1
            // 
            eventsToolStripMenuItem1.Name = "eventsToolStripMenuItem1";
            eventsToolStripMenuItem1.Size = new Size(180, 22);
            eventsToolStripMenuItem1.Text = "Events";
            // 
            // viewEventsToolStripMenuItem
            // 
            viewEventsToolStripMenuItem.Name = "viewEventsToolStripMenuItem";
            viewEventsToolStripMenuItem.Size = new Size(180, 22);
            viewEventsToolStripMenuItem.Text = "View Events ";
            viewEventsToolStripMenuItem.Click += viewEventsToolStripMenuItem_Click;
            // 
            // addEventToolStripMenuItem
            // 
            addEventToolStripMenuItem.Name = "addEventToolStripMenuItem";
            addEventToolStripMenuItem.Size = new Size(180, 22);
            addEventToolStripMenuItem.Text = "Add Event ";
            addEventToolStripMenuItem.Click += addEventToolStripMenuItem_Click;
            // 
            // removeEventsToolStripMenuItem
            // 
            removeEventsToolStripMenuItem.Name = "removeEventsToolStripMenuItem";
            removeEventsToolStripMenuItem.Size = new Size(180, 22);
            removeEventsToolStripMenuItem.Text = "Remove Events";
            // 
            // bookingToolStripMenuItem
            // 
            bookingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewTotalBookingsToolStripMenuItem, bookAnEventToolStripMenuItem });
            bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            bookingToolStripMenuItem.Size = new Size(63, 20);
            bookingToolStripMenuItem.Text = "Booking";
            // 
            // viewTotalBookingsToolStripMenuItem
            // 
            viewTotalBookingsToolStripMenuItem.Name = "viewTotalBookingsToolStripMenuItem";
            viewTotalBookingsToolStripMenuItem.Size = new Size(179, 22);
            viewTotalBookingsToolStripMenuItem.Text = "View Total Bookings";
            // 
            // bookAnEventToolStripMenuItem
            // 
            bookAnEventToolStripMenuItem.Name = "bookAnEventToolStripMenuItem";
            bookAnEventToolStripMenuItem.Size = new Size(179, 22);
            bookAnEventToolStripMenuItem.Text = "Book an event";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(62, 20);
            logOutToolStripMenuItem.Text = "Log Out";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 420);
            panel1.TabIndex = 1;
            // 
            // AdminMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AdminMain";
            Text = "AdminMain";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem addUsersToolStripMenuItem;
        private ToolStripMenuItem removeUsersToolStripMenuItem;
        private ToolStripMenuItem viewTotalUsersToolStripMenuItem;
        private ToolStripMenuItem eventsToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem eventsToolStripMenuItem1;
        private ToolStripMenuItem viewEventsToolStripMenuItem;
        private ToolStripMenuItem addEventToolStripMenuItem;
        private ToolStripMenuItem removeEventsToolStripMenuItem;
        private ToolStripMenuItem bookingToolStripMenuItem;
        private ToolStripMenuItem viewTotalBookingsToolStripMenuItem;
        private ToolStripMenuItem bookAnEventToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private Panel panel1;
    }
}