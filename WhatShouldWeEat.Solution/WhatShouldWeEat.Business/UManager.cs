using System;
using WhatShouldWeEat.Business.Abstract;
using WhatShouldWeEat.Business.Results;
using WhatShouldWeEat.Common.Helpers;
using WhatShouldWeEat.Entities;
using WhatShouldWeEat.Entities.ErrorMessages;

namespace WhatShouldWeEat.Business
{
    public class UManager : ManagerBase<users>
    {
        public BusinessResult<users> RegisterNewUser(users model)
        {
            users user = Find(x => x.username == model.username || x.mailadress == model.mailadress);
            BusinessResult<users> result = new BusinessResult<users>();

            if (user != null)
            {
                if (user.username == model.username)
                {
                    result.AddError(ErrorMessages.UsernameAlreadyExist, "Kullanıcı adı kayıtlı.");
                }

                if (user.mailadress == model.mailadress)
                {
                    result.AddError(ErrorMessages.EmailAlreadyExist, "E-Posta Kullanımda.");
                }
            }
            else
            {
                model.id = null;
                model.userkey = model.username;
                model.isadmin = false;
                model.isactive = false;
                model.migroskey = "migros";
                model.getirkey = "getir";
                int dbresult = base.Insert(model);

                if (dbresult > 0)
                {
                    result.Result = Find(x => x.mailadress == model.mailadress && x.username == model.username);

                    //TODO : AKTIVASYON MAILI ATILACAK. -> https://localhost:5001

                    string siteUrl = "https://localhost:5001";
                    string activateUrl = $"{siteUrl}/Account/ActivateUser/{result.Result.userkey}";
                    string body = $"Hesabınızı aktifleştirmek için lütfen <a href='{activateUrl}' target='_blank'>tıklayınız</a>.";

                    MailHelper.SendMail(body, result.Result.mailadress, "What Should We Eat Activation");
                }
            }

            return result;
        }

        public BusinessResult<users> ActivateUser(string userkey)
        {
            BusinessResult<users> result = new BusinessResult<users>();
            result.Result = Find(x => x.userkey == userkey);

            if (result.Result != null)
            {
                if (result.Result.isactive)
                {
                    result.AddError(ErrorMessages.UserIsAlreadyActive, "Kullanıcı zaten aktif.");
                    return result;
                }

                result.Result.isactive = true;
                Update(result.Result);
            }
            else
            {
                result.AddError(ErrorMessages.ActiveteError, "Böyle bir Kullanıcı Bulunamadı");
            }
            return result;
        }

        public BusinessResult<users> RemoveUserById(int id)
        {
            BusinessResult<users> result = new BusinessResult<users>();
            users user = Find(x => x.id == id);

            if (user != null)
            {
                if (Delete(user) == 0)
                {
                    result.AddError(ErrorMessages.UserCouldNotRemove, "Kullanıcı Silinemedi..");
                    return result;
                }
            }
            else
            {
                result.AddError(ErrorMessages.UserCouldNotFind, "Kullanıcı Bulunamadı.");
            }

            return result;
        }

        public new BusinessResult<users> UpdateProfile(users model)
        {
            users user = Find(x => x.id != model.id && (x.username == model.username || x.mailadress == model.mailadress));
            BusinessResult<users> result = new BusinessResult<users>();

            result.Result = model;

            if (user != null && user.id != model.id)
            {
                if (user.username == model.username)
                {
                    result.AddError(ErrorMessages.UsernameAlreadyExist, "Kullanıcı Adı Kullanımda");

                }
                if (user.mailadress == model.mailadress)
                {
                    result.AddError(ErrorMessages.EmailAlreadyExist, "E-Posta Adresi kullanımda");
                }
                return result;
            }

            result.Result = Find(x => x.id == model.id);
            result.Result.mailadress = model.mailadress;
            result.Result.password = model.password;
            result.Result.username = model.username;
            result.Result.isactive = model.isactive;
            result.Result.isadmin = model.isadmin;

            if (base.Update(result.Result) == 0)
            {
                result.AddError(ErrorMessages.ProfileCouldNotUpdate, "Profil güncellenemedi");
            }

            return result;
        }
    }
}
