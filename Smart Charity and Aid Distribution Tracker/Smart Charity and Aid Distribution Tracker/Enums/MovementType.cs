namespace Smart_Charity_and_Aid_Distribution_Tracker.Enums
{
    public enum MovementType
    {
        In,         // وارد (إضافة للمخزون، مثل التبرعات)
        Out,        // صادر (خصم من المخزون، مثل التوزيع)
        Adjustment  // تسوية (تعديل يدوي للمخزون في حال وجود عجز أو زيادة غير مسجلة)
    }
}
