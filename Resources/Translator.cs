using Newtonsoft.Json;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.IO;
using BC.Dal.Business;
using BC.Dal.Entity;

namespace BC.Resources
{
    public  class Translator
    {
        private Dictionary<string, Dictionary<string, string>> languageTranslations;
        private dynamic translations;
        private BConfig bConfig = new BConfig();
        protected Config eConfig = new Config();

        public Translator(Control.ControlCollection controls,  string _language, MenuStrip menuStrip = null)
        {
            // Load translations from JSON file
            LoadLanguageTranslations();
            eConfig = bConfig.GetConfig();
            
            ApplyLanguageTranslation(controls, eConfig.Language, menuStrip);
        }
        public void LoadLanguageTranslations()
        {
            //Read the contents of the JSON file
            string json = File.ReadAllText("translations.json");

            //Deserialize the JSON to the translation dictionary
            languageTranslations = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(json);
        }

        public string GetTranslation(string element)
        {
            string replyTranslator = "";
            if (translations.ContainsKey(element))
                replyTranslator = translations[element];
            
            return replyTranslator;
        }

        public void ApplyLanguageTranslation(Control.ControlCollection controls, string language, MenuStrip menuStrip = null)
        {
            if (languageTranslations.ContainsKey(language))
            {
                translations = languageTranslations[language];

                ApplyTranslationRecursively(controls, translations);

                if (menuStrip != null)
                    ApplyTranslationToMenuItems(menuStrip.Items, translations);
            }
        }

        private void ApplyTranslationRecursively(Control.ControlCollection controls, Dictionary<string, string> translations)
        {
            foreach (Control control in controls)
            {
                if (translations.ContainsKey(control.Name))
                {
                    control.Text = translations[control.Name];
                }

                if (control.Controls.Count > 0)
                {
                    ApplyTranslationRecursively(control.Controls, translations);
                }
            }
        }

        private void ApplyTranslationToMenuItems(ToolStripItemCollection menuItems, Dictionary<string, string> translations)
        {
            foreach (ToolStripItem menuItem in menuItems)
            {
                if (menuItem is ToolStripMenuItem)
                {
                    if (translations.ContainsKey(menuItem.Name))
                    {
                        menuItem.Text = translations[menuItem.Name];
                    }

                    ApplyTranslationToMenuItems(((ToolStripMenuItem)menuItem).DropDownItems, translations);
                }
                else if (translations.ContainsKey(menuItem.Name))
                {
                    menuItem.Text = translations[menuItem.Name];
                }
            }
        }
        private  ToolStripItem FindMenuItemByName(MenuStrip menuStrip, string name)
        {
            foreach (ToolStripItem menuItem in menuStrip.Items)
            {
                if (menuItem.Name == name)
                    return menuItem;

                if (menuItem is ToolStripDropDownItem dropDownItem)
                {
                    var foundMenuItem = FindMenuItemByName(dropDownItem.DropDownItems, name);
                    if (foundMenuItem != null)
                        return foundMenuItem;
                }
            }

            return null;
        }
        private ToolStripItem FindMenuItemByName(ToolStripItemCollection items, string name)
        {
            foreach (ToolStripItem menuItem in items)
            {
                if (menuItem.Name == name)
                    return menuItem;

                if (menuItem is ToolStripDropDownItem dropDownItem)
                {
                    var foundMenuItem = FindMenuItemByName(dropDownItem.DropDownItems, name);
                    if (foundMenuItem != null)
                        return foundMenuItem;
                }
            }

            return null;
        }
    }
}
