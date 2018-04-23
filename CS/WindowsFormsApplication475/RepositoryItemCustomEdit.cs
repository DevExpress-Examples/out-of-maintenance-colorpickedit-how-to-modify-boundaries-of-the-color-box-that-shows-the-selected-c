using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;

namespace WindowsFormsApplication475 {
    [UserRepositoryItem("RegisterCustomEdit")]
    public class RepositoryItemCustomEdit : RepositoryItemColorPickEdit {

        //The static constructor that calls the registration method 
        static RepositoryItemCustomEdit() { RegisterCustomEdit(); }

        //Initialize new properties 
        public RepositoryItemCustomEdit() {
            useDefaultMode = true;
        }

        //The unique name for the custom editor 
        public const string CustomEditName = "CustomEdit";

        //Return the unique name 
        public override string EditorTypeName { get { return CustomEditName; } }

        //Register the editor 
        public static void RegisterCustomEdit() {
            //Icon representing the editor within a container editor's Designer 
            Image img = null;
            try {
                img = (Bitmap)Bitmap.FromStream(Assembly.GetExecutingAssembly().
                  GetManifestResourceStream("DevExpress.CustomEditors.CustomEdit.bmp"));
            } catch {
            }
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName,
              typeof(CustomEdit), typeof(RepositoryItemCustomEdit),
              typeof(ColorEditViewInfo), new ColorEditPainter(), true, img));
        }

        //A custom property 
        private bool useDefaultMode;

        public bool UseDefaultMode {
            get { return useDefaultMode; }
            set {
                if (useDefaultMode != value) {
                    useDefaultMode = value;
                    OnPropertiesChanged();
                }
            }
        }

        //Override the Assign method 
        public override void Assign(RepositoryItem item) {
            BeginUpdate();
            try {
                base.Assign(item);
                RepositoryItemCustomEdit source = item as RepositoryItemCustomEdit;
                if (source == null) return;
                useDefaultMode = source.UseDefaultMode;
            } finally {
                EndUpdate();
            }
        }
        public override BaseEditViewInfo CreateViewInfo() {
            return new MyColorEditViewInfo(this);
        }
    }


}
