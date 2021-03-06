﻿//
// 请注意：bbsmax 不是一个免费产品，源代码仅限用于学习，禁止用于商业站点或者其他商业用途
// 如果您要将bbsmax用于商业用途，需要从官方购买商业授权，得到授权后可以基于源代码二次开发
//
// 版权所有 厦门麦斯网络科技有限公司
// 公司网站 www.bbsmax.com
//

using System;
using System.Text;
using System.Data;
using System.Collections.Generic;

using MaxLabs.bbsMax.Providers;
using MaxLabs.bbsMax.Entities;
using MaxLabs.bbsMax.Enums;
using MaxLabs.bbsMax.Rescourses;
using MaxLabs.bbsMax.DataAccess;
using MaxLabs.bbsMax.Settings;

namespace MaxLabs.bbsMax.PointActions
{
   
    public class SharePointAction : PointActionBase<SharePointAction, SharePointType, NullEnum>
	{
        public override string Name
        {
            get { return Lang.SharePointTypeName; }
        }

        public override bool Enable
        {
            get
            {
                return AllSettings.Current.ShareSettings.EnableShareFunction;
            }
        }
    }

    public enum SharePointType
	{
        [PointActionItem(Lang.SharePointType_CreateShare,false, true)]
        CreateShare,

        [PointActionItem(Lang.SharePointType_CreateCollection, false, true)]
        CreateCollection,

		/// <summary>
		/// 自己删除
		/// </summary>
        [PointActionItem(Lang.SharePointType_ShareWasDeletedBySelf, false, false)]
        ShareWasDeletedBySelf,

        /// <summary>
        /// 管理员删除
        /// </summary>
        [PointActionItem(Lang.SharePointType_ShareWasDeletedByAdmin, false, false)]
        ShareWasDeletedByAdmin,

		/// <summary>
		/// 被评论
		/// </summary>
        [PointActionItem(Lang.SharePointType_ShareWasCommeted, false, false)]
		ShareWasCommeted
	}
}