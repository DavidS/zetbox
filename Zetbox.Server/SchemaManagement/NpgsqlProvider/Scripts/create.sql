﻿SET statement_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = off;
SET check_function_bodies = false;
SET client_min_messages = warning;
SET escape_string_warning = off;

CREATE ROLE zetbox LOGIN
  ENCRYPTED PASSWORD '....'
  NOSUPERUSER INHERIT CREATEDB NOCREATEROLE;

DROP DATABASE zetbox CASCADE;
DROP DATABASE zetbox_test CASCADE;

CREATE DATABASE zetbox WITH TEMPLATE = template0 ENCODING = 'UTF8';
ALTER DATABASE zetbox OWNER TO zetbox;

CREATE DATABASE zetbox_test WITH TEMPLATE = template0 ENCODING = 'UTF8';
ALTER DATABASE zetbox_test OWNER TO zetbox;

\connect zetbox

SET statement_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = off;
SET check_function_bodies = false;
SET client_min_messages = warning;
SET escape_string_warning = off;

CREATE SCHEMA dbo;
ALTER SCHEMA dbo OWNER TO zetbox;

CREATE PROCEDURAL LANGUAGE plpgsql;
ALTER PROCEDURAL LANGUAGE plpgsql OWNER TO postgres;

REVOKE ALL ON SCHEMA dbo FROM PUBLIC;
REVOKE ALL ON SCHEMA dbo FROM zetbox;
GRANT ALL ON SCHEMA dbo TO zetbox;

CREATE OR REPLACE FUNCTION public.uuid_generate_v4()
RETURNS uuid
AS '$libdir/uuid-ossp', 'uuid_generate_v4'
VOLATILE STRICT LANGUAGE C;

\connect zetbox_test

SET statement_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = off;
SET check_function_bodies = false;
SET client_min_messages = warning;
SET escape_string_warning = off;

CREATE SCHEMA dbo;
ALTER SCHEMA dbo OWNER TO zetbox;

CREATE PROCEDURAL LANGUAGE plpgsql;
ALTER PROCEDURAL LANGUAGE plpgsql OWNER TO postgres;

REVOKE ALL ON SCHEMA dbo FROM PUBLIC;
REVOKE ALL ON SCHEMA dbo FROM zetbox;
GRANT ALL ON SCHEMA dbo TO zetbox;

CREATE OR REPLACE FUNCTION public.uuid_generate_v4()
RETURNS uuid
AS '$libdir/uuid-ossp', 'uuid_generate_v4'
VOLATILE STRICT LANGUAGE C;
