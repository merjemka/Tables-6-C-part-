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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tables_6
{

    public partial class MainWindow : Window
    {
        flowDoc = new FlowDocument();
         table1 = new Table();

        flowDoc.Blocks.Add(table1);

            table1.CellSpacing=10;
            table1.Background =Brushes.White;


     int numberOfColumns = 6;
     for (int x = 0; x<numberOfColumns; x++)
            {
    table1.Columns.Add(new TableColumn());

    if(x%2 == 0)
        table1.Columns[x].Background = Brushes.Beige;
    else
        table1.Columns[x].Background = Brushes.LightSteelBlue;
            }


table1.RowGroups.Add(new TableRowGroup());

table1.RowGroups[0].Rows.Add(new TableRow());

TableRow currentRow = table1.RowGroups[0].Rows[0];

currentRow.Background = Brushes.Silver;
currentRow.FontSize = 40;
currentRow.FontWeight = System.Windows.FontWeights.Bold;

currentRow.Cells.Add(new TableCell(new Paragraph(new Run("2004 Sales Project"))));
currentRow.Cells[0].ColumnSpan = 6;

table1.RowGroups[0].Rows.Add(new TableRow());
currentRow = table1.RowGroups[0].Rows[1];


currentRow.FontSize = 18;
currentRow.FontWeight = FontWeights.Bold;


currentRow.Cells.Add(new TableCell(new Paragraph(new Run("Product"))));
currentRow.Cells.Add(new TableCell(new Paragraph(new Run("Quarter 1"))));
currentRow.Cells.Add(new TableCell(new Paragraph(new Run("Quarter 2"))));
currentRow.Cells.Add(new TableCell(new Paragraph(new Run("Quarter 3"))));
currentRow.Cells.Add(new TableCell(new Paragraph(new Run("Quarter 4"))));
currentRow.Cells.Add(new TableCell(new Paragraph(new Run("TOTAL"))));



table1.RowGroups[0].Rows.Add(new TableRow());
currentRow = table1.RowGroups[0].Rows[2];

currentRow.FontSize = 12;
currentRow.FontWeight = FontWeights.Normal;


currentRow.Cells.Add(new TableCell(new Paragraph(new Run("Widgets"))));
currentRow.Cells.Add(new TableCell(new Paragraph(new Run("$50,000"))));
currentRow.Cells.Add(new TableCell(new Paragraph(new Run("$55,000"))));
currentRow.Cells.Add(new TableCell(new Paragraph(new Run("$60,000"))));
currentRow.Cells.Add(new TableCell(new Paragraph(new Run("$65,000"))));
currentRow.Cells.Add(new TableCell(new Paragraph(new Run("$230,000"))));


currentRow.Cells[0].FontWeight = FontWeights.Bold;

 table1.RowGroups[0].Rows.Add(new TableRow());
currentRow = table1.RowGroups[0].Rows[3];


currentRow.Background = Brushes.LightGray;
currentRow.FontSize = 18;
currentRow.FontWeight = System.Windows.FontWeights.Normal;

currentRow.Cells.Add(new TableCell(new Paragraph(new Run("Projected 2004 Revenue: $810,000"))));

currentRow.Cells[0].ColumnSpan = 6;
     }
}

