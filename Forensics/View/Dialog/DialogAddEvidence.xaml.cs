﻿using Forensics.ViewModel.Dialog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Forensics.View.Dialog
{
    /// <summary>
    /// Interaction logic for DialogAddEvidence.xaml
    /// </summary>
    public partial class DialogAddEvidence : Window
    {
        public DialogAddEvidence(string savePath)
        {
            InitializeComponent();

            DialogEvidenceViewModel vm = new DialogEvidenceViewModel(savePath);
            vm.View = this;
            this.DataContext = vm;
        }
    }
}
