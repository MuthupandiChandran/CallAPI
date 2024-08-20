

namespace CallAPI
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
            txtResponse = new RichTextBox();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtID = new TextBox();
            btnGet = new Button();
            btnGetAll = new Button();
            btnPost = new Button();
            btnPut = new Button();
            txtQuantity = new TextBox();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // txtResponse
            // 
            txtResponse.Location = new Point(0, 203);
            txtResponse.Name = "txtResponse";
            txtResponse.Size = new Size(800, 271);
            txtResponse.TabIndex = 2;
            txtResponse.Text = "";
            // 
            // txtName
            // 
            txtName.Location = new Point(336, 30);
            txtName.Name = "txtName";
            txtName.Size = new Size(83, 23);
            txtName.TabIndex = 4;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(336, 72);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(83, 23);
            txtPrice.TabIndex = 5;
            // 
            // txtID
            // 
            txtID.Location = new Point(186, 47);
            txtID.Name = "txtID";
            txtID.Size = new Size(99, 23);
            txtID.TabIndex = 6;
            txtID.TextChanged += textBox3_TextChanged;
            // 
            // btnGet
            // 
            btnGet.Font = new Font("Segoe UI", 12F);
            btnGet.Location = new Point(186, 81);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(99, 33);
            btnGet.TabIndex = 7;
            btnGet.Text = "GET";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += button2_ClickAsync;
            // 
            // btnGetAll
            // 
            btnGetAll.Font = new Font("Segoe UI", 12F);
            btnGetAll.Location = new Point(23, 50);
            btnGetAll.Name = "btnGetAll";
            btnGetAll.Size = new Size(125, 64);
            btnGetAll.TabIndex = 8;
            btnGetAll.Text = "GET ALL";
            btnGetAll.UseVisualStyleBackColor = true;
            btnGetAll.Click += button3_Click;
            // 
            // btnPost
            // 
            btnPost.Font = new Font("Segoe UI", 12F);
            btnPost.Location = new Point(437, 47);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(109, 67);
            btnPost.TabIndex = 9;
            btnPost.Text = "POST";
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += button4_Click;
            // 
            // btnPut
            // 
            btnPut.Font = new Font("Segoe UI", 12F);
            btnPut.Location = new Point(552, 47);
            btnPut.Name = "btnPut";
            btnPut.Size = new Size(116, 67);
            btnPut.TabIndex = 10;
            btnPut.Text = "PUT";
            btnPut.UseVisualStyleBackColor = true;
            btnPut.Click += button5_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(336, 120);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(83, 23);
            txtQuantity.TabIndex = 11;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(683, 47);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(105, 67);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(txtQuantity);
            Controls.Add(btnPut);
            Controls.Add(btnPost);
            Controls.Add(btnGetAll);
            Controls.Add(btnGet);
            Controls.Add(txtID);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(txtResponse);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        

        private async void button2_ClickAsync(object sender, EventArgs e) //GET
        {
            var response = await RestHelper.Get(txtID.Text);
            txtResponse.Text = RestHelper.BeautifyJson(response);
        }

        private async void button4_Click(object sender, EventArgs e) //POST
        {
            var response = await RestHelper.Post(txtName.Text, txtPrice.Text,txtQuantity.Text);
            txtResponse.Text = RestHelper.BeautifyJson(response);
        }

        #endregion

        private RichTextBox txtResponse;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtID;
        private Button btnGet;
        private Button btnGetAll;
        private Button btnPost;
        private Button btnPut;
        private TextBox txtQuantity;
        private Button btnDelete;
    }
}
