﻿using FreeSql.Internal.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FreeSql.Internal.CommonProvider
{

    public abstract class Select10Provider<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : Select0Provider<ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, T1>, ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
            where T2 : class where T3 : class where T4 : class where T5 : class where T6 : class where T7 : class where T8 : class where T9 : class where T10 : class
    {

        public Select10Provider(IFreeSql orm, CommonUtils commonUtils, CommonExpression commonExpression, object dywhere) : base(orm, commonUtils, commonExpression, dywhere)
        {
            if (_orm.CodeFirst.IsAutoSyncStructure) _orm.CodeFirst.SyncStructure(typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10));
            _tables.Add(new SelectTableInfo { Table = _commonUtils.GetTableByEntity(typeof(T2)), Alias = $"SP10b", On = null, Type = SelectTableInfoType.From });
            _tables.Add(new SelectTableInfo { Table = _commonUtils.GetTableByEntity(typeof(T3)), Alias = $"SP10c", On = null, Type = SelectTableInfoType.From });
            _tables.Add(new SelectTableInfo { Table = _commonUtils.GetTableByEntity(typeof(T4)), Alias = $"SP10d", On = null, Type = SelectTableInfoType.From });
            _tables.Add(new SelectTableInfo { Table = _commonUtils.GetTableByEntity(typeof(T5)), Alias = $"SP10e", On = null, Type = SelectTableInfoType.From });
            _tables.Add(new SelectTableInfo { Table = _commonUtils.GetTableByEntity(typeof(T6)), Alias = $"SP10f", On = null, Type = SelectTableInfoType.From });
            _tables.Add(new SelectTableInfo { Table = _commonUtils.GetTableByEntity(typeof(T7)), Alias = $"SP10g", On = null, Type = SelectTableInfoType.From });
            _tables.Add(new SelectTableInfo { Table = _commonUtils.GetTableByEntity(typeof(T8)), Alias = $"SP10h", On = null, Type = SelectTableInfoType.From });
            _tables.Add(new SelectTableInfo { Table = _commonUtils.GetTableByEntity(typeof(T9)), Alias = $"SP10i", On = null, Type = SelectTableInfoType.From });
            _tables.Add(new SelectTableInfo { Table = _commonUtils.GetTableByEntity(typeof(T10)), Alias = $"SP10j", On = null, Type = SelectTableInfoType.From });

        }

        ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.WithSql(string sqlT1, string sqlT2, string sqlT3, string sqlT4, string sqlT5, string sqlT6, string sqlT7, string sqlT8, string sqlT9, string sqlT10, object parms)
        {
            this.AsTable((type, old) =>
            {
                if (type == _tables[0].Table?.Type && string.IsNullOrEmpty(sqlT1) == false) return $"({sqlT1})";
                if (type == _tables[1].Table?.Type && string.IsNullOrEmpty(sqlT2) == false) return $"({sqlT2})";
                if (type == _tables[2].Table?.Type && string.IsNullOrEmpty(sqlT3) == false) return $"({sqlT3})";
                if (type == _tables[3].Table?.Type && string.IsNullOrEmpty(sqlT4) == false) return $"({sqlT4})";
                if (type == _tables[4].Table?.Type && string.IsNullOrEmpty(sqlT5) == false) return $"({sqlT5})";
                if (type == _tables[5].Table?.Type && string.IsNullOrEmpty(sqlT6) == false) return $"({sqlT6})";
                if (type == _tables[6].Table?.Type && string.IsNullOrEmpty(sqlT7) == false) return $"({sqlT7})";
                if (type == _tables[7].Table?.Type && string.IsNullOrEmpty(sqlT8) == false) return $"({sqlT8})";
                if (type == _tables[8].Table?.Type && string.IsNullOrEmpty(sqlT9) == false) return $"({sqlT9})";
                if (type == _tables[9].Table?.Type && string.IsNullOrEmpty(sqlT10) == false) return $"({sqlT10})";

                return old;
            });
            if (parms != null) _params.AddRange(_commonUtils.GetDbParamtersByObject($"{sqlT1};\r\n{sqlT2};\r\n{sqlT3};\r\n{sqlT4};\r\n{sqlT5};\r\n{sqlT6};\r\n{sqlT7};\r\n{sqlT8};\r\n{sqlT9};\r\n{sqlT10}", parms));
            return this;
        }

        double ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Avg<TMember>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TMember>> column)
        {
            if (column == null) return default(double);
            for (var a = 0; a < column.Parameters.Count; a++) _tables[a].Parameter = column.Parameters[a];
            return this.InternalAvg(column?.Body);
        }

        ISelectGrouping<TKey, NativeTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.GroupBy<TKey>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TKey>> exp)
        {
            if (exp == null) return this.InternalGroupBy<TKey, NativeTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>(exp?.Body);
            for (var a = 0; a < exp.Parameters.Count; a++) _tables[a].Parameter = exp.Parameters[a];
            return this.InternalGroupBy<TKey, NativeTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>(exp?.Body);
        }

        TMember ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Max<TMember>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TMember>> column)
        {
            if (column == null) return default(TMember);
            for (var a = 0; a < column.Parameters.Count; a++) _tables[a].Parameter = column.Parameters[a];
            return this.InternalMax<TMember>(column?.Body);
        }

        TMember ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Min<TMember>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TMember>> column)
        {
            if (column == null) return default(TMember);
            for (var a = 0; a < column.Parameters.Count; a++) _tables[a].Parameter = column.Parameters[a];
            return this.InternalMin<TMember>(column?.Body);
        }

        ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.OrderBy<TMember>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TMember>> column)
        {
            if (column == null) this.InternalOrderBy(column?.Body);
            for (var a = 0; a < column.Parameters.Count; a++) _tables[a].Parameter = column.Parameters[a];
            return this.InternalOrderBy(column?.Body);
        }

        ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.OrderByDescending<TMember>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TMember>> column)
        {
            if (column == null) this.InternalOrderBy(column?.Body);
            for (var a = 0; a < column.Parameters.Count; a++) _tables[a].Parameter = column.Parameters[a];
            return this.InternalOrderByDescending(column?.Body);
        }

        ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.OrderByIf<TMember>(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TMember>> column, bool descending)
        {
            if (condition == false || column == null) this.InternalOrderBy(column?.Body);
            for (var a = 0; a < column.Parameters.Count; a++) _tables[a].Parameter = column.Parameters[a];
            return descending ? this.InternalOrderByDescending(column?.Body) : this.InternalOrderBy(column?.Body);
        }

        decimal ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Sum<TMember>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TMember>> column)
        {
            if (column == null) this.InternalOrderBy(column?.Body);
            for (var a = 0; a < column.Parameters.Count; a++) _tables[a].Parameter = column.Parameters[a];
            return this.InternalSum(column?.Body);
        }

        TReturn ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.ToAggregate<TReturn>(Expression<Func<ISelectGroupingAggregate<T1>, ISelectGroupingAggregate<T2>, ISelectGroupingAggregate<T3>, ISelectGroupingAggregate<T4>, ISelectGroupingAggregate<T5>, ISelectGroupingAggregate<T6>, ISelectGroupingAggregate<T7>, ISelectGroupingAggregate<T8>, ISelectGroupingAggregate<T9>, ISelectGroupingAggregate<T10>, TReturn>> select)
        {
            if (select == null) return default(TReturn);
            for (var a = 0; a < select.Parameters.Count; a++) _tables[a].Parameter = select.Parameters[a];
            return this.InternalToAggregate<TReturn>(select?.Body);
        }
        ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Aggregate<TReturn>(Expression<Func<ISelectGroupingAggregate<T1>, ISelectGroupingAggregate<T2>, ISelectGroupingAggregate<T3>, ISelectGroupingAggregate<T4>, ISelectGroupingAggregate<T5>, ISelectGroupingAggregate<T6>, ISelectGroupingAggregate<T7>, ISelectGroupingAggregate<T8>, ISelectGroupingAggregate<T9>, ISelectGroupingAggregate<T10>, TReturn>> select, out TReturn result)
        {
            result = (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).ToAggregate(select);
            return this;
        }

        List<TReturn> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.ToList<TReturn>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn>> select)
        {
            if (select == null) return this.InternalToList<TReturn>(select?.Body);
            for (var a = 0; a < select.Parameters.Count; a++) _tables[a].Parameter = select.Parameters[a];
            return this.InternalToList<TReturn>(select?.Body);
        }

        List<TDto> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.ToList<TDto>() => (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).ToList(GetToListDtoSelector<TDto>());
        Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TDto>> GetToListDtoSelector<TDto>()
        {
            return Expression.Lambda<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TDto>>(
                typeof(TDto).InternalNewExpression(),
                _tables[0].Parameter ?? Expression.Parameter(typeof(T1), "a"), Expression.Parameter(typeof(T2), "b"), Expression.Parameter(typeof(T3), "c"), Expression.Parameter(typeof(T4), "d"), Expression.Parameter(typeof(T5), "e"), Expression.Parameter(typeof(T6), "f"), Expression.Parameter(typeof(T7), "g"), Expression.Parameter(typeof(T8), "h"), Expression.Parameter(typeof(T9), "i"), Expression.Parameter(typeof(T10), "j"));
        }

        public void ToChunk<TReturn>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn>> select, int size, Action<FetchCallbackArgs<List<TReturn>>> done)
        {
            if (select == null || done == null) return;
            for (var a = 0; a < select.Parameters.Count; a++) _tables[a].Parameter = select.Parameters[a];
            this.InternalToChunk<TReturn>(select.Body, size, done);
        }

        DataTable ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.ToDataTable<TReturn>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn>> select)
        {
            if (select == null) return this.InternalToDataTable(select?.Body);
            for (var a = 0; a < select.Parameters.Count; a++) _tables[a].Parameter = select.Parameters[a];
            return this.InternalToDataTable(select?.Body);
        }

        int ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.InsertInto<TTargetEntity>(string tableName, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TTargetEntity>> select)
        {
            if (select == null) return this.InternalInsertInto<TTargetEntity>(tableName, select);
            for (var a = 0; a < select.Parameters.Count; a++) _tables[a].Parameter = select.Parameters[a];
            return this.InternalInsertInto<TTargetEntity>(tableName, select?.Body);
        }

        string ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.ToSql<TReturn>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn>> select, FieldAliasOptions fieldAlias)
        {
            if (select == null) return this.InternalToSql<TReturn>(select?.Body, fieldAlias);
            for (var a = 0; a < select.Parameters.Count; a++) _tables[a].Parameter = select.Parameters[a];
            return this.InternalToSql<TReturn>(select?.Body, fieldAlias);
        }

        ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.LeftJoin(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool>> exp)
        {
            if (exp == null) return this.InternalJoin(exp?.Body, SelectTableInfoType.LeftJoin);
            for (var a = 0; a < exp.Parameters.Count; a++) _tables[a].Parameter = exp.Parameters[a];
            return this.InternalJoin(exp?.Body, SelectTableInfoType.LeftJoin);
        }

        ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.InnerJoin(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool>> exp)
        {
            if (exp == null) return this.InternalJoin(exp?.Body, SelectTableInfoType.LeftJoin);
            for (var a = 0; a < exp.Parameters.Count; a++) _tables[a].Parameter = exp.Parameters[a];
            return this.InternalJoin(exp?.Body, SelectTableInfoType.InnerJoin);
        }

        ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.RightJoin(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool>> exp)
        {
            if (exp == null) return this.InternalJoin(exp?.Body, SelectTableInfoType.LeftJoin);
            for (var a = 0; a < exp.Parameters.Count; a++) _tables[a].Parameter = exp.Parameters[a];
            return this.InternalJoin(exp?.Body, SelectTableInfoType.RightJoin);
        }

        ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Where(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool>> exp)
        {
            if (exp == null) return this.Where(null);
            for (var a = 0; a < exp.Parameters.Count; a++) _tables[a].Parameter = exp.Parameters[a];
            return this.Where(_commonExpression.ExpressionWhereLambda(_tables, exp?.Body, null, _whereGlobalFilter, _params));
        }

        ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.WhereIf(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool>> exp)
        {
            if (condition == false || exp == null) return this;
            for (var a = 0; a < exp.Parameters.Count; a++) _tables[a].Parameter = exp.Parameters[a];
            return this.Where(_commonExpression.ExpressionWhereLambda(_tables, exp?.Body, null, _whereGlobalFilter, _params));
        }

        bool ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Any(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool>> exp)
        {
            if (exp == null) return this.Any();
            for (var a = 0; a < exp.Parameters.Count; a++) _tables[a].Parameter = exp.Parameters[a];
            var oldwhere = _where.ToString();
            var ret = this.Where(_commonExpression.ExpressionWhereLambda(_tables, exp?.Body, null, _whereGlobalFilter, _params)).Any();
            _where.Clear().Append(oldwhere);
            return ret;
        }

        TReturn ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.ToOne<TReturn>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn>> select) => (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).Limit(1).ToList(select).FirstOrDefault();
        TReturn ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.First<TReturn>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn>> select) => (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).Limit(1).ToList(select).FirstOrDefault();
        TDto ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.First<TDto>() => (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).Limit(1).ToList<TDto>().FirstOrDefault();





        #region HzyTuple 元组

        double ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Avg<TMember>(Expression<Func<HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TMember>> column)
        {
            var expModify = new CommonExpression.ReplaceHzyTupleToMultiParam().Modify(column, _tables);
            return (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).Avg((Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TMember>>)expModify);
        }

        ISelectGrouping<TKey, NativeTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.GroupBy<TKey>(Expression<Func<HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TKey>> exp)
        {
            var expModify = new CommonExpression.ReplaceHzyTupleToMultiParam().Modify(exp, _tables);
            return (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).GroupBy((Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TKey>>)expModify);
        }

        TMember ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Max<TMember>(Expression<Func<HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TMember>> column)
        {
            var expModify = new CommonExpression.ReplaceHzyTupleToMultiParam().Modify(column, _tables);
            return (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).Max((Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TMember>>)expModify);
        }

        TMember ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Min<TMember>(Expression<Func<HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TMember>> column)
        {
            var expModify = new CommonExpression.ReplaceHzyTupleToMultiParam().Modify(column, _tables);
            return (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).Min((Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TMember>>)expModify);
        }

        ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.OrderBy<TMember>(Expression<Func<HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TMember>> column)
        {
            var expModify = new CommonExpression.ReplaceHzyTupleToMultiParam().Modify(column, _tables);
            return (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).OrderBy((Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TMember>>)expModify);
        }

        ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.OrderByDescending<TMember>(Expression<Func<HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TMember>> column)
        {
            var expModify = new CommonExpression.ReplaceHzyTupleToMultiParam().Modify(column, _tables);
            return (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).OrderByDescending((Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TMember>>)expModify);
        }

        ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.OrderByIf<TMember>(bool condition, Expression<Func<HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TMember>> column, bool descending)
        {
            var expModify = new CommonExpression.ReplaceHzyTupleToMultiParam().Modify(column, _tables);
            return (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).OrderByIf(condition, (Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TMember>>)expModify, descending);
        }

        decimal ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Sum<TMember>(Expression<Func<HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TMember>> column)
        {
            var expModify = new CommonExpression.ReplaceHzyTupleToMultiParam().Modify(column, _tables);
            return (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).Sum((Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TMember>>)expModify);
        }

        List<TReturn> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.ToList<TReturn>(Expression<Func<HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TReturn>> select)
        {
            var expModify = new CommonExpression.ReplaceHzyTupleToMultiParam().Modify(select, _tables);
            return (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).ToList((Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn>>)expModify);
        }

        public void ToChunk<TReturn>(Expression<Func<HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TReturn>> select, int size, Action<FetchCallbackArgs<List<TReturn>>> done)
        {
            var expModify = new CommonExpression.ReplaceHzyTupleToMultiParam().Modify(select, _tables);
            (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).ToChunk((Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn>>)expModify, size, done);
        }

        DataTable ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.ToDataTable<TReturn>(Expression<Func<HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TReturn>> select)
        {
            var expModify = new CommonExpression.ReplaceHzyTupleToMultiParam().Modify(select, _tables);
            return (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).ToDataTable((Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn>>)expModify);
        }

        int ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.InsertInto<TTargetEntity>(string tableName, Expression<Func<HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TTargetEntity>> select)
        {
            var expModify = new CommonExpression.ReplaceHzyTupleToMultiParam().Modify(select, _tables);
            return (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).InsertInto(tableName, (Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TTargetEntity>>)expModify);
        }

        string ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.ToSql<TReturn>(Expression<Func<HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TReturn>> select, FieldAliasOptions fieldAlias)
        {
            var expModify = new CommonExpression.ReplaceHzyTupleToMultiParam().Modify(select, _tables);
            return (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).ToSql((Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn>>)expModify, fieldAlias);
        }

        ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.LeftJoin(Expression<Func<HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, bool>> exp)
        {
            var expModify = new CommonExpression.ReplaceHzyTupleToMultiParam().Modify(exp, _tables);
            return (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).LeftJoin((Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool>>)expModify);
        }

        ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.InnerJoin(Expression<Func<HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, bool>> exp)
        {
            var expModify = new CommonExpression.ReplaceHzyTupleToMultiParam().Modify(exp, _tables);
            return (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).InnerJoin((Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool>>)expModify);
        }

        ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.RightJoin(Expression<Func<HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, bool>> exp)
        {
            var expModify = new CommonExpression.ReplaceHzyTupleToMultiParam().Modify(exp, _tables);
            return (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).RightJoin((Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool>>)expModify);
        }

        ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Where(Expression<Func<HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, bool>> exp)
        {
            var expModify = new CommonExpression.ReplaceHzyTupleToMultiParam().Modify(exp, _tables);
            return (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).Where((Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool>>)expModify);
        }

        ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.WhereIf(bool condition, Expression<Func<HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, bool>> exp)
        {
            var expModify = new CommonExpression.ReplaceHzyTupleToMultiParam().Modify(exp, _tables);
            return (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).WhereIf(condition, (Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool>>)expModify);
        }

        bool ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Any(Expression<Func<HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, bool>> exp)
        {
            var expModify = new CommonExpression.ReplaceHzyTupleToMultiParam().Modify(exp, _tables);
            return (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).Any((Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool>>)expModify);
        }

        TReturn ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.ToOne<TReturn>(Expression<Func<HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TReturn>> select)
            => (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).Limit(1).ToList(select).FirstOrDefault();
        TReturn ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.First<TReturn>(Expression<Func<HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TReturn>> select)
            => (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).Limit(1).ToList(select).FirstOrDefault();

        #endregion



#if net40
#else
        Task<double> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.AvgAsync<TMember>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TMember>> column)
        {
            if (column == null) return Task.FromResult(default(double));
            for (var a = 0; a < column.Parameters.Count; a++) _tables[a].Parameter = column.Parameters[a];
            return this.InternalAvgAsync(column?.Body);
        }

        Task<TMember> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.MaxAsync<TMember>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TMember>> column)
        {
            if (column == null) return Task.FromResult(default(TMember));
            for (var a = 0; a < column.Parameters.Count; a++) _tables[a].Parameter = column.Parameters[a];
            return this.InternalMaxAsync<TMember>(column?.Body);
        }

        Task<TMember> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.MinAsync<TMember>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TMember>> column)
        {
            if (column == null) return Task.FromResult(default(TMember));
            for (var a = 0; a < column.Parameters.Count; a++) _tables[a].Parameter = column.Parameters[a];
            return this.InternalMinAsync<TMember>(column?.Body);
        }

        Task<decimal> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.SumAsync<TMember>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TMember>> column)
        {
            if (column == null) this.InternalOrderBy(column?.Body);
            for (var a = 0; a < column.Parameters.Count; a++) _tables[a].Parameter = column.Parameters[a];
            return this.InternalSumAsync(column?.Body);
        }

        Task<TReturn> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.ToAggregateAsync<TReturn>(Expression<Func<ISelectGroupingAggregate<T1>, ISelectGroupingAggregate<T2>, ISelectGroupingAggregate<T3>, ISelectGroupingAggregate<T4>, ISelectGroupingAggregate<T5>, ISelectGroupingAggregate<T6>, ISelectGroupingAggregate<T7>, ISelectGroupingAggregate<T8>, ISelectGroupingAggregate<T9>, ISelectGroupingAggregate<T10>, TReturn>> select)
        {
            if (select == null) return Task.FromResult(default(TReturn));
            for (var a = 0; a < select.Parameters.Count; a++) _tables[a].Parameter = select.Parameters[a];
            return this.InternalToAggregateAsync<TReturn>(select?.Body);
        }

        Task<List<TReturn>> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.ToListAsync<TReturn>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn>> select)
        {
            if (select == null) return this.InternalToListAsync<TReturn>(select?.Body);
            for (var a = 0; a < select.Parameters.Count; a++) _tables[a].Parameter = select.Parameters[a];
            return this.InternalToListAsync<TReturn>(select?.Body);
        }
        Task<List<TDto>> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.ToListAsync<TDto>() => (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).ToListAsync(GetToListDtoSelector<TDto>());

        Task<DataTable> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.ToDataTableAsync<TReturn>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn>> select)
        {
            if (select == null) return this.InternalToDataTableAsync(select?.Body);
            for (var a = 0; a < select.Parameters.Count; a++) _tables[a].Parameter = select.Parameters[a];
            return this.InternalToDataTableAsync(select?.Body);
        }

        Task<int> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.InsertIntoAsync<TTargetEntity>(string tableName, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TTargetEntity>> select)
        {
            if (select == null) return this.InternalInsertIntoAsync<TTargetEntity>(tableName, select);
            for (var a = 0; a < select.Parameters.Count; a++) _tables[a].Parameter = select.Parameters[a];
            return this.InternalInsertIntoAsync<TTargetEntity>(tableName, select?.Body);
        }

        async Task<bool> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.AnyAsync(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool>> exp)
        {
            if (exp == null) return await this.AnyAsync();
            for (var a = 0; a < exp.Parameters.Count; a++) _tables[a].Parameter = exp.Parameters[a];
            var oldwhere = _where.ToString();
            var ret = await this.Where(_commonExpression.ExpressionWhereLambda(_tables, exp?.Body, null, _whereGlobalFilter, _params)).AnyAsync();
            _where.Clear().Append(oldwhere);
            return ret;
        }

        async Task<TReturn> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.ToOneAsync<TReturn>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn>> select) => (await (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).Limit(1).ToListAsync(select)).FirstOrDefault();
        async Task<TReturn> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.FirstAsync<TReturn>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn>> select) => (await (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).Limit(1).ToListAsync(select)).FirstOrDefault();
        async Task<TDto> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.FirstAsync<TDto>() => (await (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).Limit(1).ToListAsync<TDto>()).FirstOrDefault();




        #region HzyTuple 元组

        Task<double> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.AvgAsync<TMember>(Expression<Func<HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TMember>> column)
        {
            var expModify = new CommonExpression.ReplaceHzyTupleToMultiParam().Modify(column, _tables);
            return (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).AvgAsync((Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TMember>>)expModify);
        }

        Task<TMember> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.MaxAsync<TMember>(Expression<Func<HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TMember>> column)
        {
            var expModify = new CommonExpression.ReplaceHzyTupleToMultiParam().Modify(column, _tables);
            return (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).MaxAsync((Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TMember>>)expModify);
        }

        Task<TMember> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.MinAsync<TMember>(Expression<Func<HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TMember>> column)
        {
            var expModify = new CommonExpression.ReplaceHzyTupleToMultiParam().Modify(column, _tables);
            return (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).MinAsync((Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TMember>>)expModify);
        }

        Task<decimal> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.SumAsync<TMember>(Expression<Func<HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TMember>> column)
        {
            var expModify = new CommonExpression.ReplaceHzyTupleToMultiParam().Modify(column, _tables);
            return (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).SumAsync((Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TMember>>)expModify);
        }

        Task<List<TReturn>> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.ToListAsync<TReturn>(Expression<Func<HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TReturn>> select)
        {
            var expModify = new CommonExpression.ReplaceHzyTupleToMultiParam().Modify(select, _tables);
            return (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).ToListAsync((Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn>>)expModify);
        }

        Task<DataTable> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.ToDataTableAsync<TReturn>(Expression<Func<HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TReturn>> select)
        {
            var expModify = new CommonExpression.ReplaceHzyTupleToMultiParam().Modify(select, _tables);
            return (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).ToDataTableAsync((Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn>>)expModify);
        }

        Task<int> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.InsertIntoAsync<TTargetEntity>(string tableName, Expression<Func<HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TTargetEntity>> select)
        {
            var expModify = new CommonExpression.ReplaceHzyTupleToMultiParam().Modify(select, _tables);
            return (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).InsertIntoAsync(tableName, (Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TTargetEntity>>)expModify);
        }

        async Task<bool> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.AnyAsync(Expression<Func<HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, bool>> exp)
        {
            var expModify = new CommonExpression.ReplaceHzyTupleToMultiParam().Modify(exp, _tables);
            return await (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).AnyAsync((Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool>>)expModify);
        }

        async Task<TReturn> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.ToOneAsync<TReturn>(Expression<Func<HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TReturn>> select)
            => (await (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).Limit(1).ToListAsync(select)).FirstOrDefault();
        async Task<TReturn> ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.FirstAsync<TReturn>(Expression<Func<HzyTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, TReturn>> select)
            => (await (this as ISelect<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>).Limit(1).ToListAsync(select)).FirstOrDefault();


        #endregion

#endif
    }




}