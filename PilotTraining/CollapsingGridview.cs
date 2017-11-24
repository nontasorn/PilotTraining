
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using PilotTraining.Class;




namespace PilotTraining.From
{
    public class CollapsingGridview : System.Windows.Forms.DataGridView
    {


        private bool Group = true;
        private List<int> groupings = new List<int>();
        private Order _order = Order.Ascending;
        private int _ordercolumn = -1;
        private List<List<int>> _groups;
        public List<int> BaseRows;
        private Color _colour = Color.White;
        //Private _consecutive As Boolean = False

        public enum Order
        {
            Ascending = 1,
            Descending = 2
        }

        [Description("Add each column index which is required to match in order to form a group."), Category("Grouping"), DisplayName("Grouping Columns")]
        public List<int> GroupingColumns
        {
            get { return groupings; }
            set
            {
                if (value.Count == 0)
                    value.Add(0);
                groupings = value;
            }
        }

        [Description("Determines if grouping behaviour is enabled."), Category("Grouping"), DisplayName("Grouping Enabled")]
        public bool GroupingEnabled
        {
            get { return Group; }
            set { Group = value; }
        }

        [Description("Determines if Ascending or Descending Order. Grouping order is based on the order column."), Category("Grouping"), DisplayName("Grouping Order Column")]
        public Order GroupingOrderColumn
        {
            get { return _order; }
            set { _order = value; }
        }

        [Description("Determines which column is used to order groups. This is necessary to identify the 'base' row for each group. A value of -1 means that it relies on existing order."), Category("Grouping"), DisplayName("Group Sorting")]
        public int GroupingOrder
        {
            get { return _ordercolumn; }
            set { _ordercolumn = value; }
        }

        //<Description("Determines if grouping is only for consecutive items or covers all items that match grouping criteria."), Category("Grouping"), DisplayName("Consecutive Only")>
        //Public Property ConsecutiveOnly() As Boolean
        //    Get
        //        Return _consecutive
        //    End Get
        //    Set(ByVal value As Boolean)
        //        _consecutive = value
        //    End Set
        //End Property

        [Description("Defines a Colour for 'Base' Rows in groups."), Category("Grouping"), DisplayName("Base Row Colour")]
       /* public Color BaseRowColour
        {
            get { return _colour; }
            set { _colour = value; }
        }
       */
        private List<int> DetermineBaseRows()
        {
            List<int> functionReturnValue = default(List<int>);

            if (GroupingEnabled == false)
                return functionReturnValue;

            try
            {
                _groups = new List<List<int>>();

                List<int> accountedrows = new List<int>();

                functionReturnValue = new List<int>();

                for (int r = 0; r <= this.RowCount - 1; r++)
                {
                    List<int> grouplist = new List<int>();

                    if (accountedrows.Contains(r) == false)
                    {
                        accountedrows.Add(r);
                        grouplist.Add(r);
                        for (int sr = 0; sr <= this.RowCount - 1; sr++)
                        {
                            if (accountedrows.Contains(sr) == false)
                            {
                                bool match = true;
                                foreach (int g in groupings)
                                {
                                    if (Rows[r].Cells[g].Value != Rows[sr].Cells[g].Value)
                                        match = false;
                                }
                                if (match == true)
                                {
                                    grouplist.Add(sr);
                                    accountedrows.Add(sr);
                                }
                                else
                                {
                                    //If ConsecutiveOnly = True Then Exit For
                                }
                            }
                        }
                        _groups.Add(grouplist);
                        if (_ordercolumn > -1)
                        {
                            try
                            {
                                int baserow = grouplist[0];

                                 List<string> sortlist = new List<string>();

                                foreach (int b in grouplist)
                                {
                                    sortlist.Add(Rows[b].Cells[_ordercolumn].Value.ToString());
                                }
                                sortlist.Sort();
                                if (_order == Order.Descending)
                                    sortlist.Reverse();

                                string value = Rows[baserow].Cells[_ordercolumn].Value.ToString();
                                int grouploop = 0;
                                while (!(value == sortlist[0]))
                                {
                                    grouploop += 1;
                                    baserow = grouplist[grouploop];
                                    value = Rows[baserow].Cells[_ordercolumn].Value.ToString();
                                    
                                }

                                functionReturnValue.Add(baserow);
                                if (string.IsNullOrEmpty(Rows[baserow].HeaderCell.Value.ToString()) & grouplist.Count > 1)
                                    Rows[baserow].HeaderCell.Value = "-";
                            }
                            catch (Exception ex)
                            {
                                functionReturnValue.Add(grouplist[0]);
                                if (string.IsNullOrEmpty(Rows[grouplist[0]].HeaderCell.Value.ToString()) & grouplist.Count > 1)
                                    Rows[grouplist[0]].HeaderCell.Value = "-";
                            }
                        }
                        if (_ordercolumn == -1)
                        {
                            functionReturnValue.Add(grouplist[0]);
                            if (string.IsNullOrEmpty(Rows[grouplist[0]].HeaderCell.Value.ToString()) & grouplist.Count > 1)
                                Rows[grouplist[0]].HeaderCell.Value = "-";
                        }
                    }
                }
                Application.DoEvents();
                for (int s = 0; s <= Rows.Count - 1; s++)
                {
                    if (!string.IsNullOrEmpty(Rows[s].HeaderCell.Value.ToString()) & functionReturnValue.Contains(s) == false)
                        Rows[s].HeaderCell.Value = "";
                }


            }
            catch (Exception ex)
            {
            }
            return functionReturnValue;
        }

        private void CollapsingGridview_Paint(object sender, PaintEventArgs e)
        {
            if (GroupingEnabled == false)
                return;
            this.SuspendLayout();
            BaseRows = DetermineBaseRows();
            ColourBases();
            this.ResumeLayout();
        }

        private void CollapsingGridview_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (GroupingEnabled == false)
                return;
            if (string.IsNullOrEmpty(Rows[e.RowIndex].HeaderCell.Value.ToString())) 
                return;
            foreach (List<int> g in _groups)
            {
                if (g.Contains(e.RowIndex))
                {
                    foreach (int sr in g)
                    {
                        if (sr != e.RowIndex)
                        {
                            if (Rows[e.RowIndex].HeaderCell.Value.ToString() == "-")
                            {
                                Rows[sr].Visible = false;
                            }
                            else
                            {
                                Rows[sr].Visible = true;
                            }
                        }
                    }
                }
            }
            if (Rows[e.RowIndex].HeaderCell.Value.ToString() == "-")
            {
                Rows[e.RowIndex].HeaderCell.Value = "+";
            }
            else
            {
                Rows[e.RowIndex].HeaderCell.Value = "-";
            }

        }


        public void CollapseAll()
        {
            if (GroupingEnabled == false)
                return;

            for (int rowindex = 0; rowindex <= Rows.Count - 1; rowindex++)
            {
                if (Rows[rowindex].HeaderCell.Value.ToString() == "-" & Rows[rowindex].Visible == true)
                {
                    foreach (List<int> g in _groups)
                    {
                        if (g.Contains(rowindex))
                        {
                            foreach (int sr in g)
                            {
                                if (sr != rowindex)
                                {
                                    Rows[sr].Visible = false;
                                }
                            }
                        }
                    }
                    Rows[rowindex].HeaderCell.Value = "+";
                }
            }
        }


        public void ExpandAll()
        {
            if (GroupingEnabled == false)
                return;
            for (int rowindex = 0; rowindex <= Rows.Count - 1; rowindex++)
            {
                if (Rows[rowindex].HeaderCell.Value.ToString() == "+" & Rows[rowindex].Visible == true)
                {
                    foreach (List<int> g in _groups)
                    {
                        if (g.Contains(rowindex))
                        {
                            foreach (int sr in g)
                            {
                                if (sr != rowindex)
                                {
                                    Rows[sr].Visible = true;
                                }
                            }
                        }
                    }
                    Rows[rowindex].HeaderCell.Value = "-";
                }
            }
        }


        private void CollapsingGridview_SortCompare(object sender, System.EventArgs e)
        {
            if (GroupingEnabled == false)
                return;
            Application.DoEvents();
            ExpandAll();
            ClearAll();
            BaseRows = DetermineBaseRows();
            ColourBases();
        }


        private void ColourBases()
        {
            if (GroupingEnabled == false)
                return;
            if (BaseRows.Count <= 0)
                return;
            foreach (int r in BaseRows)
            {
                Rows[r].DefaultCellStyle.BackColor = _colour;
            }
        }


        private void ClearAll()
        {
            if (GroupingEnabled == false)
                return;
            BaseRows.Clear();
            _groups.Clear();
            for (int r = 0; r <= RowCount - 1; r++)
            {
                Rows[r].DefaultCellStyle.BackColor = this.DefaultCellStyle.BackColor;
                
            }
        }
        public CollapsingGridview()
        {
            Sorted += CollapsingGridview_SortCompare;
            RowHeaderMouseClick += CollapsingGridview_RowHeaderMouseClick;
            Paint += CollapsingGridview_Paint;
        }
    }
}


//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
