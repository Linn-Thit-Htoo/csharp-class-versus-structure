namespace csharp_class_versus_structure;

public class Program
{
    public static void Main(string[] args)
    {
        BlogClass blogClass = new()
        {
            BlogId = Guid.NewGuid(),
            BlogTitle = "Blog Title 1",
            BlogAuthor = "Blog Author 1",
            BlogContent = "Blog Content 1",
            IsDeleted = false,
        };
        BlogStruct blogStruct = new();

        blogStruct.BlogId = Guid.NewGuid();
        blogStruct.BlogTitle = "Blog Title 1";
        blogStruct.BlogAuthor = "Blog Author 1";
        blogStruct.BlogContent = "Blog Content 1";
        blogStruct.IsDeleted = false;

        ChangeValues(blogClass);
        ChangeValues(blogStruct);

        Console.WriteLine("Class Values: \n");
        Console.WriteLine($"Blog Id: {blogClass.BlogId}");
        Console.WriteLine($"Blog Title: {blogClass.BlogTitle}");
        Console.WriteLine($"Blog Author: {blogClass.BlogAuthor}");
        Console.WriteLine($"Blog Content: {blogClass.BlogContent}");
        Console.WriteLine($"Is Deleted: {blogClass.IsDeleted}");

        Console.WriteLine("---------------------------------------");

        Console.WriteLine("Struct Values: \n");
        Console.WriteLine($"Blog Id: {blogStruct.BlogId}");
        Console.WriteLine($"Blog Title: {blogStruct.BlogTitle}");
        Console.WriteLine($"Blog Author: {blogStruct.BlogAuthor}");
        Console.WriteLine($"Blog Content: {blogStruct.BlogContent}");
        Console.WriteLine($"Is Deleted: {blogStruct.IsDeleted}");
    }

    public static void ChangeValues(BlogClass @blog)
    {
        blog.BlogTitle = "Blog Title 1 changed";
        blog.BlogAuthor = "Blog Author 1 changed";
        blog.BlogContent = "Blog Content 1 changed";
    }

    public static void ChangeValues(BlogStruct @blog)
    {
        blog.BlogTitle = "Blog Title 1 changed";
        blog.BlogAuthor = "Blog Author 1 changed";
        blog.BlogContent = "Blog Content 1 changed";
    }
}

public struct BlogStruct // value type
{
    public Guid BlogId { get; set; }
    public string BlogTitle { get; set; }
    public string BlogAuthor { get; set; }
    public string BlogContent { get; set; }
    public bool IsDeleted { get; set; }
}

public class BlogClass // reference type
{
    public Guid BlogId { get; set; }
    public string BlogTitle { get; set; }
    public string BlogAuthor { get; set; }
    public string BlogContent { get; set; }
    public bool IsDeleted { get; set; }
}
