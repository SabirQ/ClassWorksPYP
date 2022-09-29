namespace ApiFirstLesson.Dtos.CategoryDtos
{
    public class CategoryCreateDto
    {
        public string CategoryName { get; set; } = null!;
        public string? Description { get; set; }
    }
    public class CategoryDto
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public string? Description { get; set; }
    }
}