namespace ChoosingMajor.DB.Domain
{
    public class TongHop
    {
        public virtual int ID { get; set; }
        public virtual string MaNghanh { get; set; }
        public virtual string MaTruong { get; set; }
        public virtual int Nam { get; set; }
        public virtual float DiemChuan { get; set; }
        public virtual string GhiChu { get; set; }
    }
}
