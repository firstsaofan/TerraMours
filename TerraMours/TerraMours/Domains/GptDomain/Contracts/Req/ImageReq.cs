﻿using System.Text.Json.Serialization;

namespace TerraMours_Gpt.Domains.GptDomain.Contracts.Req {
    /// <summary>
    /// 图片发起类
    /// </summary>
    public class ImageReq {
        /// <summary>
        /// 提问词
        /// </summary>
        public string Prompt { get; set; }

        /// <summary>
        /// 生成图片数量
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// 图片尺寸 256/512/1024
        /// </summary>
        public int? Size { get; set; }

        /// <summary>
        /// signalR 客户端Id
        /// </summary>
        public string ConnectionId { get; set; }

        /// <summary>
        /// 模型
        /// </summary>
        public string? Model { get; set; }
        /// <summary>
        /// 模型类型 0 gpt 1 sd
        /// </summary>
        public int? ModelType { get; set; }

        [JsonIgnore]
        public string? Key { get; set; }
        [JsonIgnore]
        public string? IP { get; set; }

        /// <summary>
        /// 用户id 自增
        /// </summary>
        [JsonIgnore]
        public long UserId { get; set; }
    }
}