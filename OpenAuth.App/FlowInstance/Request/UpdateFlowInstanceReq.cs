//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
//     Author:Yubao Li
// </autogenerated>
//------------------------------------------------------------------------------

using System.ComponentModel;

namespace OpenAuth.App.Request
{
    /// <summary>
	/// 创建工作流请求
	/// </summary>
    public class UpdateFlowInstanceReq : NodeDesignateReq
    {
	    
	    /// <summary>
	    /// 待更改的流程实例ID
	    /// </summary>
	    public string Id { get; set; }

        /// <summary>
	    /// 实例编号
	    /// </summary>
         [Description("实例编号")]
        public string Code { get; set; }
        /// <summary>
	    /// 自定义名称
	    /// </summary>
         [Description("自定义名称")]
        public string CustomName { get; set; }

        /// <summary>
	    /// 数据库名称
	    /// </summary>
         [Description("数据库名称")]
        public string DbName { get; set; }
        /// <summary>
	    /// 表单数据
	    /// </summary>
         [Description("表单数据")]
        public string FrmData { get; set; }
      
       
        
        /// <summary>
        /// 所属部门
        /// </summary>
        [Description("所属部门")]
        public string OrgId { get; set; }

        /// <summary>
	    /// 实例备注
	    /// </summary>
         [Description("实例备注")]
        public string Description { get; set; }

    }
}