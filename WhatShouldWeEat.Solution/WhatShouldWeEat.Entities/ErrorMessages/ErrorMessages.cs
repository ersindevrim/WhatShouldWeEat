using System;
namespace WhatShouldWeEat.Entities.ErrorMessages
{
    public enum ErrorMessages
    {
        UserNotFound = 400,
        UsernameAlreadyExist = 401,
        EmailAlreadyExist = 402,
        UsernameOrPassWrong = 403,
        UserIsNotActive = 501,
        UserIsAlreadyActive = 502,
        ActiveteError = 503,
        ProfileCouldNotUpdate = 101,
        UserCouldNotRemove = 102,
        UserCouldNotFind = 103
    }
}
