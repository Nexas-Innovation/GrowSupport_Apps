using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GrowUpNavi.ViewModels.Account
{
    /// <summary>
    /// ログイン画面のビューモデル
    /// </summary>
    public class LoginViewModel
    {
        /// <summary>
        /// ID（メールアドレス）
        /// </summary>
        [DataType(DataType.EmailAddress)]
        public string Id { get; set; }

        /// <summary>
        /// パスワード
        /// </summary>
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}