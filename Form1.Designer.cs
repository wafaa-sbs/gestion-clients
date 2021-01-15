
namespace gestion_clients
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.adresse = new System.Windows.Forms.TextBox();
            this.ville = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.villesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestion_cltDataSet = new gestion_clients.gestion_cltDataSet();
            this.villesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.villesTableAdapter = new gestion_clients.gestion_cltDataSetTableAdapters.villesTableAdapter();
            this.cbville = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_cltDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(121, 66);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(154, 26);
            this.id.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LavenderBlush;
            this.label1.Location = new System.Drawing.Point(14, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(121, 115);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(154, 26);
            this.name.TabIndex = 3;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(121, 170);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(154, 26);
            this.lastname.TabIndex = 4;
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(121, 226);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(154, 26);
            this.adresse.TabIndex = 5;
            // 
            // ville
            // 
            this.ville.Location = new System.Drawing.Point(121, 286);
            this.ville.Name = "ville";
            this.ville.Size = new System.Drawing.Size(154, 26);
            this.ville.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(388, 383);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 46);
            this.button5.TabIndex = 16;
            this.button5.Text = "Mise à jour";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(40, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 46);
            this.button1.TabIndex = 12;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(156, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 46);
            this.button2.TabIndex = 13;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(272, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 46);
            this.button3.TabIndex = 14;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(324, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(660, 224);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LavenderBlush;
            this.label2.Location = new System.Drawing.Point(14, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "name :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LavenderBlush;
            this.label3.Location = new System.Drawing.Point(14, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Last name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LavenderBlush;
            this.label4.Location = new System.Drawing.Point(14, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "adresse :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LavenderBlush;
            this.label5.Location = new System.Drawing.Point(14, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "ville :";
            // 
            // villesBindingSource
            // 
            this.villesBindingSource.DataMember = "villes";
            this.villesBindingSource.DataSource = this.gestion_cltDataSet;
            // 
            // gestion_cltDataSet
            // 
            this.gestion_cltDataSet.DataSetName = "gestion_cltDataSet";
            this.gestion_cltDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // villesBindingSource1
            // 
            this.villesBindingSource1.DataMember = "villes";
            this.villesBindingSource1.DataSource = this.gestion_cltDataSet;
            // 
            // villesTableAdapter
            // 
            this.villesTableAdapter.ClearBeforeFill = true;
            // 
            // cbville
            // 
            this.cbville.FormattingEnabled = true;
            this.cbville.Items.AddRange(new object[] {
            "casablanca",
            "rabat",
            "settat",
            "youssoufia",
            "safi",
            "marrakech",
            "meknes",
            "fes",
            "tanger"});
            this.cbville.Location = new System.Drawing.Point(659, 393);
            this.cbville.Name = "cbville";
            this.cbville.Size = new System.Drawing.Size(209, 28);
            this.cbville.TabIndex = 20;
            this.cbville.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(747, 453);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(120, 35);
            this.btn_search.TabIndex = 21;
            this.btn_search.Text = "chercher";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 523);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.cbville);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ville);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_cltDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.TextBox ville;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private gestion_cltDataSet gestion_cltDataSet;
        private System.Windows.Forms.BindingSource villesBindingSource;
        private gestion_cltDataSetTableAdapters.villesTableAdapter villesTableAdapter;
        private System.Windows.Forms.BindingSource villesBindingSource1;
        private System.Windows.Forms.ComboBox cbville;
        private System.Windows.Forms.Button btn_search;
    }
}

