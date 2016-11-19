namespace ExcelIngenieria
{
    partial class RbIngenieria : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public RbIngenieria()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RbIngenieria));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.Btn_Produccion = this.Factory.CreateRibbonButton();
            this.Btn_Ore = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.Btn_Cargadores = this.Factory.CreateRibbonButton();
            this.Btn_Camion = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Label = "Ingenieria";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.Btn_Produccion);
            this.group1.Items.Add(this.Btn_Ore);
            this.group1.Label = "Produccion";
            this.group1.Name = "group1";
            // 
            // Btn_Produccion
            // 
            this.Btn_Produccion.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Produccion.Image")));
            this.Btn_Produccion.Label = "&Produccion";
            this.Btn_Produccion.Name = "Btn_Produccion";
            this.Btn_Produccion.ShowImage = true;
            this.Btn_Produccion.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_Hola_Click);
            // 
            // Btn_Ore
            // 
            this.Btn_Ore.Image = global::ExcelIngenieria.Properties.Resources.analitica__1_;
            this.Btn_Ore.Label = "Rep. Ore";
            this.Btn_Ore.Name = "Btn_Ore";
            this.Btn_Ore.ShowImage = true;
            // 
            // group2
            // 
            this.group2.Items.Add(this.Btn_Cargadores);
            this.group2.Items.Add(this.Btn_Camion);
            this.group2.Label = "Equipos";
            this.group2.Name = "group2";
            // 
            // Btn_Cargadores
            // 
            this.Btn_Cargadores.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cargadores.Image")));
            this.Btn_Cargadores.Label = "Cargadores";
            this.Btn_Cargadores.Name = "Btn_Cargadores";
            this.Btn_Cargadores.ShowImage = true;
            this.Btn_Cargadores.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_Cargadores_Click);
            // 
            // Btn_Camion
            // 
            this.Btn_Camion.Image = global::ExcelIngenieria.Properties.Resources.camion_volteador__2_;
            this.Btn_Camion.Label = "Camiones";
            this.Btn_Camion.Name = "Btn_Camion";
            this.Btn_Camion.ShowImage = true;
            this.Btn_Camion.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_Camion_Click);
            // 
            // RbIngenieria
            // 
            this.Name = "RbIngenieria";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.RbIngenieria_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Btn_Produccion;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Btn_Cargadores;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Btn_Camion;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Btn_Ore;
    }

    partial class ThisRibbonCollection
    {
        internal RbIngenieria RbIngenieria
        {
            get { return this.GetRibbon<RbIngenieria>(); }
        }
    }
}
