﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorioSolver
{
    public interface IUiInterface
    {
        TextBox TextErrors { get; set; }
        TextBox TextIngredient { get; set; }
        TextBox TextTotalPerSecond { get; set; }
        TextBox TextMiningProductivity { get; set; }
        ComboBox ItemsBox { get; set; }

        bool CheckBoxSplitBelts { get; }

        // For drawing
        Graphics G { get; }
        TextBox TopLeftMain { get; }
        TextBox TopLeftRefinery { get; }
        TextBox TopLeftMining { get; }
        Label StringSize { get; }

        // For testing.
        bool Testing { get; }

        event Action ClickCalculate;
        event Action ClickOptimizeBeltLoad;
    }
}
