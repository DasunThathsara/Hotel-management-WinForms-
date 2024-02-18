using System.Net;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace Hotel_management
{
    partial class ReservationDetails
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
            RID = new TextBox();
            name = new TextBox();
            address = new TextBox();
            room = new TextBox();
            RID_L = new Label();
            name_L = new Label();
            address_L = new Label();
            room_L = new Label();
            insertBtn = new Button();
            updateBtn = new Button();
            deleteBtn = new Button();
            searchBtn = new Button();
            clearBtn = new Button();
            SuspendLayout();
            // 
            // RID
            // 
            RID.Location = new Point(331, 58);
            RID.Name = "RID";
            RID.Size = new Size(339, 27);
            RID.TabIndex = 0;
            // 
            // name
            // 
            name.Location = new Point(331, 117);
            name.Name = "name";
            name.Size = new Size(339, 27);
            name.TabIndex = 1;
            // 
            // address
            // 
            address.Location = new Point(331, 177);
            address.Name = "address";
            address.Size = new Size(339, 27);
            address.TabIndex = 2;
            // 
            // room
            // 
            room.Location = new Point(331, 243);
            room.Name = "room";
            room.Size = new Size(339, 27);
            room.TabIndex = 3;
            // 
            // RID_L
            // 
            RID_L.AutoSize = true;
            RID_L.Location = new Point(144, 58);
            RID_L.Name = "RID_L";
            RID_L.Size = new Size(105, 20);
            RID_L.TabIndex = 4;
            RID_L.Text = "Reservation ID";
            // 
            // name_L
            // 
            name_L.AutoSize = true;
            name_L.Location = new Point(158, 117);
            name_L.Name = "name_L";
            name_L.Size = new Size(91, 20);
            name_L.TabIndex = 5;
            name_L.Text = "Client Name";
            // 
            // address_L
            // 
            address_L.AutoSize = true;
            address_L.Location = new Point(142, 180);
            address_L.Name = "address_L";
            address_L.Size = new Size(107, 20);
            address_L.TabIndex = 6;
            address_L.Text = "CLient Address";
            // 
            // room_L
            // 
            room_L.AutoSize = true;
            room_L.Location = new Point(142, 246);
            room_L.Name = "room_L";
            room_L.Size = new Size(107, 20);
            room_L.TabIndex = 7;
            room_L.Text = "Room Number";
            // 
            // insertBtn
            // 
            insertBtn.Location = new Point(114, 304);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new Size(152, 50);
            insertBtn.TabIndex = 8;
            insertBtn.Text = "Insert";
            insertBtn.UseVisualStyleBackColor = true;
            insertBtn.Click += insertBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(331, 304);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(152, 50);
            updateBtn.TabIndex = 9;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(556, 304);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(152, 50);
            deleteBtn.TabIndex = 10;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(224, 377);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(152, 50);
            searchBtn.TabIndex = 11;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(450, 377);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(152, 50);
            clearBtn.TabIndex = 12;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            // 
            // ReservationDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clearBtn);
            Controls.Add(searchBtn);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(insertBtn);
            Controls.Add(room_L);
            Controls.Add(address_L);
            Controls.Add(name_L);
            Controls.Add(RID_L);
            Controls.Add(room);
            Controls.Add(address);
            Controls.Add(name);
            Controls.Add(RID);
            Name = "ReservationDetails";
            Text = "Reservation Details";
            Load += ReservationDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RID;
        private TextBox name;
        private TextBox address;
        private TextBox room;
        private Label RID_L;
        private Label name_L;
        private Label address_L;
        private Label room_L;
        private Button insertBtn;
        private Button updateBtn;
        private Button deleteBtn;
        private Button searchBtn;
        private Button clearBtn;
    }
}