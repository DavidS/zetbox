﻿
# Entities

Entities are created for each class, for each class of collection entry (one per N:M relation) and for each list of ValueTypes.

# Kinds of Associations

* Every 1:1 or 1:N ObjectReference: A -> B

    ctx.GetQuery<Relation>()
        .Where(r => r.GetPreferredStorage() != StorageHint.Separate)
        .OrderBy(r => r.GetAssociationName())

    ctx.GetRelationsWithoutSeparateStorage()

* N:M relations have two:  A -> Collection Entry, B -> Collection Entry

    ctx.GetQuery<Relation>()
        .Where(r => r.GetPreferredStorage() == StorageHint.Separate)
        .OrderBy(r => r.GetAssociationName())

    ctx.GetRelationsWithSeparateStorage()

* ValueType lists: Container (A) -> Value (B)

    ctx.GetQuery<ValueTypeProperty>()
        .Where(p => p.IsList)
        .OrderBy(p => p.ObjectClass.Name)
        .ThenBy(p => p.Name)



# Misc notes

* make modifications first in CSDL and SSDL. MSL follows naturally and is bad place to make design decisions.