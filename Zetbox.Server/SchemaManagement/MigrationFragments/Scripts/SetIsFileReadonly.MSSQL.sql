﻿update doc.[Files] set [IsFileReadonly] = 1 where exists (select * from doc.[StaticFiles] s where s.[ID] = doc.[Files].[ID])