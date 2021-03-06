/* 
 * 
 * (c) Copyright Ascensio System Limited 2010-2014
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Affero General Public License as
 * published by the Free Software Foundation, either version 3 of the
 * License, or (at your option) any later version.
 * 
 * http://www.gnu.org/licenses/agpl.html 
 * 
 */


using System.Collections.Generic;
namespace ASC.Web.Core.Subscriptions
{    
    public enum GroupByType
    {
        Modules,
        Groups,
        Simple 
    }
    public interface IProductSubscriptionManager : ISubscriptionManager
    {
        GroupByType GroupByType { get; }
        List<SubscriptionGroup> GetSubscriptionGroups();
    }

}
