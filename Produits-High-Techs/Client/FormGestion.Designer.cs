namespace Produits_High_Techs.Client
{
    partial class FormGestion
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
            this.labelNumero = new System.Windows.Forms.Label();
            this.labelQuantite = new System.Windows.Forms.Label();
            this.labelPrix = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.textBoxQuantite = new System.Windows.Forms.TextBox();
            this.textBoxPrix = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxRecherche = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonEcrire = new System.Windows.Forms.Button();
            this.buttonLire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumero.Location = new System.Drawing.Point(54, 34);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(54, 13);
            this.labelNumero.TabIndex = 0;
            this.labelNumero.Text = "Numero:";
            // 
            // labelQuantite
            // 
            this.labelQuantite.AutoSize = true;
            this.labelQuantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantite.Location = new System.Drawing.Point(54, 73);
            this.labelQuantite.Name = "labelQuantite";
            this.labelQuantite.Size = new System.Drawing.Size(59, 13);
            this.labelQuantite.TabIndex = 1;
            this.labelQuantite.Text = "Quantite:";
            // 
            // labelPrix
            // 
            this.labelPrix.AutoSize = true;
            this.labelPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrix.Location = new System.Drawing.Point(54, 110);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(32, 13);
            this.labelPrix.TabIndex = 2;
            this.labelPrix.Text = "Prix:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(317, 34);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(39, 13);
            this.labelType.TabIndex = 3;
            this.labelType.Text = "Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(317, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date de Fabrication:";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(126, 27);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumero.TabIndex = 5;
            this.textBoxNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumero_KeyPress);
            // 
            // textBoxQuantite
            // 
            this.textBoxQuantite.Location = new System.Drawing.Point(126, 66);
            this.textBoxQuantite.Name = "textBoxQuantite";
            this.textBoxQuantite.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantite.TabIndex = 6;
            this.textBoxQuantite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQuantite_KeyPress);
            // 
            // textBoxPrix
            // 
            this.textBoxPrix.Location = new System.Drawing.Point(126, 103);
            this.textBoxPrix.Name = "textBoxPrix";
            this.textBoxPrix.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrix.TabIndex = 7;
            this.textBoxPrix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrix_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(463, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Cd",
            "Livre",
            "Logiciel",
            "Magazine",
            "Unknown"});
            this.comboBoxType.Location = new System.Drawing.Point(463, 26);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType.TabIndex = 9;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(57, 162);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Ajouter";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(151, 155);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(75, 36);
            this.buttonDisplay.TabIndex = 11;
            this.buttonDisplay.Text = "Afficher Tout";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(246, 162);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Supprimer";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(344, 162);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 13;
            this.buttonUpdate.Text = "Modifier";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(445, 162);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 14;
            this.buttonReset.Text = "Rafraichir";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(541, 162);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "Quitter";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(36, 347);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(627, 134);
            this.listBox1.TabIndex = 16;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(405, 289);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(63, 13);
            this.labelSearch.TabIndex = 17;
            this.labelSearch.Text = "Recherche:";
            // 
            // textBoxRecherche
            // 
            this.textBoxRecherche.Location = new System.Drawing.Point(482, 282);
            this.textBoxRecherche.Name = "textBoxRecherche";
            this.textBoxRecherche.Size = new System.Drawing.Size(100, 20);
            this.textBoxRecherche.TabIndex = 18;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(588, 279);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 19;
            this.buttonSearch.Text = "Rechercher";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Quantite";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Prix";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(451, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Date de fabrication";
            // 
            // buttonEcrire
            // 
            this.buttonEcrire.Location = new System.Drawing.Point(496, 200);
            this.buttonEcrire.Name = "buttonEcrire";
            this.buttonEcrire.Size = new System.Drawing.Size(75, 38);
            this.buttonEcrire.TabIndex = 25;
            this.buttonEcrire.Text = "Ecrire dans le fichier";
            this.buttonEcrire.UseVisualStyleBackColor = true;
            this.buttonEcrire.Click += new System.EventHandler(this.buttonEcrire_Click);
            // 
            // buttonLire
            // 
            this.buttonLire.Location = new System.Drawing.Point(588, 200);
            this.buttonLire.Name = "buttonLire";
            this.buttonLire.Size = new System.Drawing.Size(75, 38);
            this.buttonLire.TabIndex = 26;
            this.buttonLire.Text = "Lire dans le Fichier";
            this.buttonLire.UseVisualStyleBackColor = true;
            this.buttonLire.Click += new System.EventHandler(this.buttonLire_Click);
            // 
            // FormGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 525);
            this.Controls.Add(this.buttonLire);
            this.Controls.Add(this.buttonEcrire);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxRecherche);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxPrix);
            this.Controls.Add(this.textBoxQuantite);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelPrix);
            this.Controls.Add(this.labelQuantite);
            this.Controls.Add(this.labelNumero);
            this.Name = "FormGestion";
            this.Text = "Gestion de Produits-High-Techs";
            this.Load += new System.EventHandler(this.FormGestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Label labelQuantite;
        private System.Windows.Forms.Label labelPrix;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.TextBox textBoxQuantite;
        private System.Windows.Forms.TextBox textBoxPrix;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxRecherche;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonEcrire;
        private System.Windows.Forms.Button buttonLire;
    }
}