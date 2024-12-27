using api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api.Data.FluentAPI
{
    public class CommentFluentAPI : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(z => z.Stock).WithMany(x => x.Comments).HasForeignKey(z => z.StockId);
        }
    }
}
