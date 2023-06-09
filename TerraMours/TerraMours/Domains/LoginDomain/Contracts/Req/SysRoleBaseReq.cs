﻿namespace TerraMours.Domains.LoginDomain.Contracts.Req
{
    public class SysRoleBaseReq
    {
        public SysRoleBaseReq()
        {
        }

        /// <summary>
        /// 主键 角色id 自增
        /// </summary>
        public long RoleId { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        public string? RoleName { get; set; }
    }
}
