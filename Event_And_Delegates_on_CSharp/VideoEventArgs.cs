using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_And_Delegates_on_CSharp
{
    public class VideoEventArgs : EventArgs
    {
        public Video video { get; set; }
    }
}
