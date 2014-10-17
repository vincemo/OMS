using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace OSM
{
    partial class AboutBox_OSM : Form
    {
        /// <summary>
        /// 构造函数,修改关于信息
        /// </summary>
        public AboutBox_OSM()
        {
            InitializeComponent();
            //this.Text = String.Format("关于 {0}", AssemblyTitle);
            //this.labelProductName_OSM.Text = AssemblyProduct;
            //this.labelVersion_OSM.Text = String.Format("版本 {0}", AssemblyVersion);
            //this.labelCopyright_OSM.Text = AssemblyCopyright;
            //this.labelCompanyName_OSM.Text = AssemblyCompany;
            //this.textBoxDescription_OSM.Text = AssemblyDescription;
            
            this.Text = "关于OSM";
            this.labelProductName_OSM.Text = "订单信息管理系统";
            this.labelVersion_OSM.Text = "版本v0.1";
            this.labelCopyright_OSM.Text = "版权所有人:MMMOOO";
            this.labelCompanyName_OSM.Text = "OSM Company.Inc";
            this.textBoxDescription_OSM.Text = "试用版";
        }

        #region 程序集特性访问器

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion
    }
}
