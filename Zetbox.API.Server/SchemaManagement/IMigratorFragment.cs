﻿// This file is part of zetbox.
//
// Zetbox is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as
// published by the Free Software Foundation, either version 3 of
// the License, or (at your option) any later version.
//
// Zetbox is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with zetbox.  If not, see <http://www.gnu.org/licenses/>.

namespace Zetbox.API.SchemaManagement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Autofac;
    using Zetbox.API.Server;
    using Zetbox.API.Utils;
    using Zetbox.App.Base;

    public interface IGlobalMigratorFragment
    {
        void PreMigration(ISchemaProvider db);
        void PostMigration(ISchemaProvider db);
    }

    public interface IMigratorFragment
    {
        Guid Target { get; }
    }

    public enum ClassMigrationEventType
    {
        Add,
        RenameTable,
        ChangeBase,
        ChangeMapping,
        Delete,
    }

    public interface IClassMigratorFragment : IMigratorFragment
    {
        ClassMigrationEventType ClassEventType { get; }

        /// <summary>
        /// Is called before the change. Unless the method is prepared to handle all possible migration cases, it should return true.
        /// </summary>
        /// <returns>true, if the default implementation of the event should run. False, otherwise. Unless the method is prepared to handle all possible migration cases, it should return true.</returns>
        bool PreMigration(ISchemaProvider db, ObjectClass oldClass, ObjectClass newClass);
        void PostMigration(ISchemaProvider db, ObjectClass oldClass, ObjectClass newClass);
    }

    public enum PropertyMigrationEventType
    {
        Add,
        Rename,
        Move,
        ChangeDefaultValueDefinition,
        ChangeToNullable,
        ChangeToNotNullable,
        Delete,
    }

    public interface IPropertyMigratorFragment : IMigratorFragment
    {
        PropertyMigrationEventType PropertyEventType { get; }

        /// <summary>
        /// Is called before the change. Unless the method is prepared to handle all possible migration cases, it should return true.
        /// </summary>
        /// <returns>true, if the default implementation of the event should run. False, otherwise. Unless the method is prepared to handle all possible migration cases, it should return true.</returns>
        bool PreMigration(ISchemaProvider db, Property oldProperty, Property newProperty);
        void PostMigration(ISchemaProvider db, Property oldProperty, Property newProperty);
    }

    public enum RelationMigrationEventType
    {
        Add,
        Rename,
        ChangeEndType,
        ChangeHasPositionStorage,
        ChangeStorage,
        ChangeToNotNullable,
        ChangeToNullable,
        ChangeType,
        Delete,
    }

    public interface IRelationMigratorFragment : IMigratorFragment
    {
        RelationMigrationEventType RelationEventType { get; }

        /// <summary>
        /// Is called before the change. Unless the method is prepared to handle all possible migration cases, it should return true.
        /// </summary>
        /// <returns>true, if the default implementation of the event should run. False, otherwise. Unless the method is prepared to handle all possible migration cases, it should return true.</returns>
        bool PreMigration(ISchemaProvider db, Relation oldRelation, Relation newRelation);
        void PostMigration(ISchemaProvider db, Relation oldRelation, Relation newRelation);
    }

    public static class AutofacExtensions
    {
        public static void RegisterMigrationFragments(this ContainerBuilder builder, System.Reflection.Assembly source)
        {
            if (builder == null) { throw new ArgumentNullException("builder"); }
            if (source == null) { throw new ArgumentNullException("source"); }

            foreach (var t in source.GetTypes()
                                    .Where(t => !t.IsAbstract
                                            && t.GetInterfaces().Contains(typeof(IGlobalMigratorFragment))))
            {
                builder
                    .RegisterType(t)
                    .AsImplementedInterfaces()
                    .SingleInstance();
            }

            foreach (var t in source.GetTypes()
                                    .Where(t => !t.IsAbstract
                                            && t.GetInterfaces().Contains(typeof(IMigratorFragment))))
            {
                builder
                    .RegisterType(t)
                    .AsImplementedInterfaces()
                    .SingleInstance();
            }
        }
    }
}
