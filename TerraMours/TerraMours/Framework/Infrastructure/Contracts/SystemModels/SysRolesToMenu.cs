﻿namespace TerraMours.Framework.Infrastructure.Contracts.SystemModels
{
    /// <summary>
    /// 用户的角色以及角色对应的菜单操作按钮权限表
    /// </summary>
    public class SysRolesToMenu : BaseEntity
    {
        /// <summary>
        /// 主键 自增 
        /// </summary>
        public long RolesToMenuId { get; set; }
        /// <summary>
        /// 角色id 外键
        /// </summary>
        public long? RoleId { get; set; }
        /// <summary>
        /// 用户id 外键
        /// </summary>
        public long? UserId { get; set; }
        /// <summary>
        /// 菜单id
        /// </summary>
        public long MenuId { get; set; }
        /// <summary>
        /// 每个菜单的按钮 外键就是 MenuId 自己
        /// </summary>
        public List<SysMenuButtons>? SysMenuButtons { get; set; }

        /// <summary>
        /// 角色导航属性
        /// </summary>
        public SysRole SysRole { get; set; }
    }
}
