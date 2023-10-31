namespace NotepadApp
{
    partial class Form1
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.TextBox();
            this.noteText = new System.Windows.Forms.TextBox();
            this.newNote = new System.Windows.Forms.Button();
            this.deleteNote = new System.Windows.Forms.Button();
            this.saveNoteButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.readNoteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(268, 30);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(33, 16);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            this.titleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Note";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // titleText
            // 
            this.titleText.BackColor = System.Drawing.Color.NavajoWhite;
            this.titleText.Location = new System.Drawing.Point(304, 24);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(468, 22);
            this.titleText.TabIndex = 2;
            this.titleText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // noteText
            // 
            this.noteText.BackColor = System.Drawing.Color.NavajoWhite;
            this.noteText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.noteText.Location = new System.Drawing.Point(307, 75);
            this.noteText.Multiline = true;
            this.noteText.Name = "noteText";
            this.noteText.Size = new System.Drawing.Size(465, 312);
            this.noteText.TabIndex = 3;
            this.noteText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // newNote
            // 
            this.newNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newNote.BackColor = System.Drawing.Color.Tan;
            this.newNote.ImageKey = "(none)";
            this.newNote.Location = new System.Drawing.Point(12, 393);
            this.newNote.Name = "newNote";
            this.newNote.Size = new System.Drawing.Size(140, 60);
            this.newNote.TabIndex = 6;
            this.newNote.Text = "New Note";
            this.newNote.UseVisualStyleBackColor = false;
            this.newNote.Click += new System.EventHandler(this.newNote_Click);
            // 
            // deleteNote
            // 
            this.deleteNote.BackColor = System.Drawing.Color.Tan;
            this.deleteNote.Location = new System.Drawing.Point(212, 393);
            this.deleteNote.Name = "deleteNote";
            this.deleteNote.Size = new System.Drawing.Size(140, 60);
            this.deleteNote.TabIndex = 7;
            this.deleteNote.Text = "Delete Note";
            this.deleteNote.UseVisualStyleBackColor = false;
            this.deleteNote.Click += new System.EventHandler(this.deleteNote_Click);
            // 
            // saveNoteButton
            // 
            this.saveNoteButton.BackColor = System.Drawing.Color.Tan;
            this.saveNoteButton.Location = new System.Drawing.Point(412, 393);
            this.saveNoteButton.Name = "saveNoteButton";
            this.saveNoteButton.Size = new System.Drawing.Size(140, 60);
            this.saveNoteButton.TabIndex = 8;
            this.saveNoteButton.Text = "Save Note";
            this.saveNoteButton.UseVisualStyleBackColor = false;
            this.saveNoteButton.Click += new System.EventHandler(this.saveNoteButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.GridColor = System.Drawing.Color.NavajoWhite;
            this.dataGridView1.Location = new System.Drawing.Point(1, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(258, 363);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // readNoteButton
            // 
            this.readNoteButton.BackColor = System.Drawing.Color.Tan;
            this.readNoteButton.Location = new System.Drawing.Point(610, 393);
            this.readNoteButton.Name = "readNoteButton";
            this.readNoteButton.Size = new System.Drawing.Size(140, 60);
            this.readNoteButton.TabIndex = 10;
            this.readNoteButton.Text = "Read Note";
            this.readNoteButton.UseVisualStyleBackColor = false;
            this.readNoteButton.Click += new System.EventHandler(this.readNoteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(784, 465);
            this.Controls.Add(this.readNoteButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.saveNoteButton);
            this.Controls.Add(this.deleteNote);
            this.Controls.Add(this.newNote);
            this.Controls.Add(this.noteText);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox noteText;
        private System.Windows.Forms.Button newNote;
        private System.Windows.Forms.Button deleteNote;
        private System.Windows.Forms.Button saveNoteButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button readNoteButton;
    }
}

