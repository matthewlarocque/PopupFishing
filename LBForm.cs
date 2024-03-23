using LayeredSkin.Forms;

namespace PopupPersonalGain 
{
    public partial class LBForm : LayeredForm
    {
        public LBForm()
        {
            InitializeComponent();
            BackgroundRender = new ShadowBackgroundRender();
        }
    }
}
