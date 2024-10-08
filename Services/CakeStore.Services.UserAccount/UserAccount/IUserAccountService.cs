﻿namespace CakeStore.Services.UserAccount;

public interface IUserAccountService
{
    Task<bool> IsEmpty();

    /// <summary>
    /// Create user account
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    Task<IEnumerable<UserAccountModel>> GetAll();
    Task<UserAccountModel> GetById(Guid id);
    Task<UserAccountModel> Create(RegisterUserAccountModel model);




    // .. Также здесь можно разместить методы для изменения данных учетной записи, восстановления и смены пароля, подтверждения электронной почты, установки телефона и его подтверждения и т.д.
    // .. Но это уже на самостоятельно.
    // .. Удачи! Я в вас верю!  :)
}
