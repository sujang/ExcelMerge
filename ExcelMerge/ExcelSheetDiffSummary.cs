﻿namespace ExcelMerge
{
    public struct ExcelSheetDiffSummary
    {
        public int ModifiedCellCount { get; set; }
        public int AddedRowCount { get; set; }
        public int RemovedRowCount { get; set; }
        public int ModifiedRowCount { get; set; }
    }
}
