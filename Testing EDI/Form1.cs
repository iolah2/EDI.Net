using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using indice.Edi;

namespace Testing_EDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var grammar = EdiGrammar.NewTradacoms();
            var interchange = default(Interchange);
            using (var stream = new StreamReader(@"c:\temp\sample.edi")) {
                interchange = new EdiSerializer().Deserialize<Interchange>(stream, grammar);
            }
        }
    }
}
