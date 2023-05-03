﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TerraMours.Framework.Infrastructure.Contracts.SystemModels
{
    public class SysRoleConfig : IEntityTypeConfiguration<SysRole>
    {
        public void Configure(EntityTypeBuilder<SysRole> builder)
        {
            //设置表
            builder.ToTable("SysRole");
            //设置表主键
            builder.HasKey(e => e.RoleId);
            //设置主键自增
            builder.Property(e => e.RoleId)
                   .UseIdentityColumn();

        }
    }
}
