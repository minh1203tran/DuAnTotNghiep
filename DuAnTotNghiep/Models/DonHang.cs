using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DuAnTotNghiep.Models
{
    public enum TrangThaiDonHang
    {
        [Display(Name = "Mới đặt")]
        MoiDat = 1,
        [Display(Name = "Đang giao")]
        DangGiao = 2,
        [Display(Name = "Đã giao")]
        DaGiao = 3
    }

    [Table("DonHang")]
    public class DonHang
    {
        [Key]
        public int DonHangId { get; set; }

        [ForeignKey("KhachHang")]
        public int KhachHangId { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "Bạn phải chọn ngày đặt."), Display(Name = "Ngày đặt")]
        public DateTime NgatDat { get; set; }

        [Required, Range(0, double.MaxValue, ErrorMessage = "Bạn phải nhập giá tiền.")]
        [Display(Name = "Tổng tiền")]
        public double TongTien { get; set; }

        [Display(Name = "Trạng thái")]
        public TrangThaiDonHang TrangThaiDonHang { get; set; }

        [StringLength(250)]
        [Display(Name = "Ghi chú")]
        [Column(TypeName = "nvarchar(250)")]
        public string GhiChu { get; set; }

        public KhachHang KhachHang { get; set; }

        public List<DonHangChiTiet> DonHangChiTiets { get; set; }
    }
}