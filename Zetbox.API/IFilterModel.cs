// This file is part of zetbox.
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
namespace Zetbox.API
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Collections;
    using System.Linq.Expressions;

    public interface IFilterModel
    {
        IQueryable GetQuery(IQueryable src);
        LambdaExpression GetExpression(IQueryable src);
        IEnumerable GetResult(IEnumerable src);
        bool IsServerSideFilter { get; }

        IFilterValueSource ValueSource { get; set; }

        /// <summary>
        /// Indicates that the filter value has been set and the filter is active.
        /// </summary>
        bool Enabled { get; }
        bool Required { get; }
    }

    public interface IFilterValueSource
    {
        string Expression { get; }
    }
}
