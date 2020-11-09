﻿using FreeSql.Internal.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FreeSql
{

    public interface ISelect<T1, T2> : ISelect0<ISelect<T1, T2>, T1> where T2 : class
    {

#if net40
#else
        Task<bool> AnyAsync(Expression<Func<T1, T2, bool>> exp);
        Task<int> InsertIntoAsync<TTargetEntity>(string tableName, Expression<Func<T1, T2, TTargetEntity>> select) where TTargetEntity : class;
        Task<DataTable> ToDataTableAsync<TReturn>(Expression<Func<T1, T2, TReturn>> select);
        Task<List<TReturn>> ToListAsync<TReturn>(Expression<Func<T1, T2, TReturn>> select);
        Task<List<TDto>> ToListAsync<TDto>();

        Task<TReturn> ToOneAsync<TReturn>(Expression<Func<T1, T2, TReturn>> select);
        Task<TReturn> FirstAsync<TReturn>(Expression<Func<T1, T2, TReturn>> select);
        Task<TDto> FirstAsync<TDto>();

        Task<TReturn> ToAggregateAsync<TReturn>(Expression<Func<ISelectGroupingAggregate<T1>, ISelectGroupingAggregate<T2>, TReturn>> select);
        Task<decimal> SumAsync<TMember>(Expression<Func<T1, T2, TMember>> column);
        Task<TMember> MinAsync<TMember>(Expression<Func<T1, T2, TMember>> column);
        Task<TMember> MaxAsync<TMember>(Expression<Func<T1, T2, TMember>> column);
        Task<double> AvgAsync<TMember>(Expression<Func<T1, T2, TMember>> column);

        #region HzyTuple 元组

        Task<bool> AnyAsync(Expression<Func<HzyTuple<T1, T2>, bool>> exp);
        Task<int> InsertIntoAsync<TTargetEntity>(string tableName, Expression<Func<HzyTuple<T1, T2>, TTargetEntity>> select) where TTargetEntity : class;
        Task<DataTable> ToDataTableAsync<TReturn>(Expression<Func<HzyTuple<T1, T2>, TReturn>> select);
        Task<List<TReturn>> ToListAsync<TReturn>(Expression<Func<HzyTuple<T1, T2>, TReturn>> select);

        Task<TReturn> ToOneAsync<TReturn>(Expression<Func<HzyTuple<T1, T2>, TReturn>> select);
        Task<TReturn> FirstAsync<TReturn>(Expression<Func<HzyTuple<T1, T2>, TReturn>> select);

        Task<decimal> SumAsync<TMember>(Expression<Func<HzyTuple<T1, T2>, TMember>> column);
        Task<TMember> MinAsync<TMember>(Expression<Func<HzyTuple<T1, T2>, TMember>> column);
        Task<TMember> MaxAsync<TMember>(Expression<Func<HzyTuple<T1, T2>, TMember>> column);
        Task<double> AvgAsync<TMember>(Expression<Func<HzyTuple<T1, T2>, TMember>> column);

        #endregion

#endif

        bool Any(Expression<Func<T1, T2, bool>> exp);
        int InsertInto<TTargetEntity>(string tableName, Expression<Func<T1, T2, TTargetEntity>> select) where TTargetEntity : class;
        DataTable ToDataTable<TReturn>(Expression<Func<T1, T2, TReturn>> select);
        List<TReturn> ToList<TReturn>(Expression<Func<T1, T2, TReturn>> select);
        List<TDto> ToList<TDto>();
        void ToChunk<TReturn>(Expression<Func<T1, T2, TReturn>> select, int size, Action<FetchCallbackArgs<List<TReturn>>> done);

        TReturn ToOne<TReturn>(Expression<Func<T1, T2, TReturn>> select);
        TReturn First<TReturn>(Expression<Func<T1, T2, TReturn>> select);
        TDto First<TDto>();

        string ToSql<TReturn>(Expression<Func<T1, T2, TReturn>> select, FieldAliasOptions fieldAlias = FieldAliasOptions.AsIndex);
        TReturn ToAggregate<TReturn>(Expression<Func<ISelectGroupingAggregate<T1>, ISelectGroupingAggregate<T2>, TReturn>> select);
        ISelect<T1, T2> Aggregate<TReturn>(Expression<Func<ISelectGroupingAggregate<T1>, ISelectGroupingAggregate<T2>, TReturn>> select, out TReturn result);
        decimal Sum<TMember>(Expression<Func<T1, T2, TMember>> column);
        TMember Min<TMember>(Expression<Func<T1, T2, TMember>> column);
        TMember Max<TMember>(Expression<Func<T1, T2, TMember>> column);
        double Avg<TMember>(Expression<Func<T1, T2, TMember>> column);

        ISelect<T1, T2> LeftJoin(Expression<Func<T1, T2, bool>> exp);
        ISelect<T1, T2> InnerJoin(Expression<Func<T1, T2, bool>> exp);
        ISelect<T1, T2> RightJoin(Expression<Func<T1, T2, bool>> exp);

        ISelect<T1, T2> Where(Expression<Func<T1, T2, bool>> exp);
        ISelect<T1, T2> WhereIf(bool condition, Expression<Func<T1, T2, bool>> exp);

        ISelectGrouping<TKey, NativeTuple<T1, T2>> GroupBy<TKey>(Expression<Func<T1, T2, TKey>> exp);

        ISelect<T1, T2> OrderBy<TMember>(Expression<Func<T1, T2, TMember>> column);
        ISelect<T1, T2> OrderByDescending<TMember>(Expression<Func<T1, T2, TMember>> column);
        ISelect<T1, T2> OrderByIf<TMember>(bool condition, Expression<Func<T1, T2, TMember>> column, bool descending = false);

        ISelect<T1, T2> WithSql(string sqlT1, string sqlT2, object parms = null);

        #region HzyTuple 元组

        bool Any(Expression<Func<HzyTuple<T1, T2>, bool>> exp);
        int InsertInto<TTargetEntity>(string tableName, Expression<Func<HzyTuple<T1, T2>, TTargetEntity>> select) where TTargetEntity : class;
        DataTable ToDataTable<TReturn>(Expression<Func<HzyTuple<T1, T2>, TReturn>> select);
        List<TReturn> ToList<TReturn>(Expression<Func<HzyTuple<T1, T2>, TReturn>> select);
        void ToChunk<TReturn>(Expression<Func<HzyTuple<T1, T2>, TReturn>> select, int size, Action<FetchCallbackArgs<List<TReturn>>> done);

        TReturn ToOne<TReturn>(Expression<Func<HzyTuple<T1, T2>, TReturn>> select);
        TReturn First<TReturn>(Expression<Func<HzyTuple<T1, T2>, TReturn>> select);

        string ToSql<TReturn>(Expression<Func<HzyTuple<T1, T2>, TReturn>> select, FieldAliasOptions fieldAlias = FieldAliasOptions.AsIndex);
        decimal Sum<TMember>(Expression<Func<HzyTuple<T1, T2>, TMember>> column);
        TMember Min<TMember>(Expression<Func<HzyTuple<T1, T2>, TMember>> column);
        TMember Max<TMember>(Expression<Func<HzyTuple<T1, T2>, TMember>> column);
        double Avg<TMember>(Expression<Func<HzyTuple<T1, T2>, TMember>> column);

        ISelect<T1, T2> LeftJoin(Expression<Func<HzyTuple<T1, T2>, bool>> exp);
        ISelect<T1, T2> InnerJoin(Expression<Func<HzyTuple<T1, T2>, bool>> exp);
        ISelect<T1, T2> RightJoin(Expression<Func<HzyTuple<T1, T2>, bool>> exp);

        ISelect<T1, T2> Where(Expression<Func<HzyTuple<T1, T2>, bool>> exp);
        ISelect<T1, T2> WhereIf(bool condition, Expression<Func<HzyTuple<T1, T2>, bool>> exp);

        ISelectGrouping<TKey, NativeTuple<T1, T2>> GroupBy<TKey>(Expression<Func<HzyTuple<T1, T2>, TKey>> exp);

        ISelect<T1, T2> OrderBy<TMember>(Expression<Func<HzyTuple<T1, T2>, TMember>> column);
        ISelect<T1, T2> OrderByDescending<TMember>(Expression<Func<HzyTuple<T1, T2>, TMember>> column);
        ISelect<T1, T2> OrderByIf<TMember>(bool condition, Expression<Func<HzyTuple<T1, T2>, TMember>> column, bool descending = false);

        #endregion

    }



}