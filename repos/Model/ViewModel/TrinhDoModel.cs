namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public  class TrinhDoModel
    {
      
        public int ID_TrinhDo { get; set; }

        public string TenTrinhDo { get; set; }

      
        public List<CV_UngVien> CV_UngVien { get; set; }

        public List<TinViecLam> TinViecLams { get; set; }
    }
}
