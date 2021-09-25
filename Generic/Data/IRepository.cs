﻿using UtilityInterface.NonGeneric.Data;

namespace UtilityInterface.Generic.Database
{

    public interface IRepository<T, TQuery, TQueryResult> : IBasicRepository<T, TQueryResult>, IQueryRepository<T, TQuery, TQueryResult>
    {
    }

    public interface IBasicRepository<T, TQueryResult> : ISingleRepository<T, TQueryResult>, IMultiRepository<T, TQueryResult>
    {
    }

    public interface IIdRepository<TId, TQueryResult> : IIdSingleRepository<TId, TQueryResult>, IIdMultiRepository<TId, TQueryResult>
    {
    }

    public interface ISingleRepository<T, TQueryResult> : IFind<T, TQueryResult>, IAdd<T, TQueryResult>, IUpdate<T, TQueryResult>, IRemove<T, TQueryResult> 
    {
    }

    public interface IMultiRepository<T, TQueryResult> : IFindMany<T, TQueryResult>, IAddMany<T, TQueryResult>, IUpdateMany<T, TQueryResult>, IRemoveMany<T, TQueryResult>
    {
    }

    public interface IQueryRepository<T, TQuery, TQueryResult> : IFindBy<TQuery, TQueryResult>, IAddBy<TQuery, TQueryResult>, IUpdateBy<TQuery, TQueryResult>, IRemoveBy<TQuery, TQueryResult>
    {
    }

    public interface IIdSingleRepository<TId, TQueryResult> : IFindById<TId, TQueryResult>, IRemoveById<TId, TQueryResult>
    {
    }

    public interface IIdMultiRepository<TId, TQueryResult> : IFindManyById<TId, TQueryResult>, IRemoveManyById<TId, TQueryResult>
    {
    }
}