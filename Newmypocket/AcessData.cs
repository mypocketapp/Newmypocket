using System.ComponentModel;

namespace Newmypocket
{
    public partial class AcessData : Component
    {
        public AcessData()
        {
            InitializeComponent();
        }

        public AcessData(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
