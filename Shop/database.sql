create table "Producto"
(
    "Id"             serial
        constraint producto_pk
            primary key,
    "PrecioUnitario" numeric not null,
    "Costo"          numeric not null
);

alter table "Producto"
    owner to postgres;

create unique index producto_id_uindex
    on "Producto" ("Id");

create table "Cliente"
(
    "Id"     serial
        constraint cliente_pk
            primary key,
    "Nombre" varchar
);

alter table "Cliente"
    owner to postgres;

create table "Venta"
(
    "Id"        serial
        constraint venta_pk
            primary key,
    fecha       timestamp default now() not null,
    "Total"     numeric                 not null,
    "IdCliente" integer                 not null
        constraint cliente___fk
            references "Cliente"
);

alter table "Venta"
    owner to postgres;

create unique index venta_id_uindex
    on "Venta" ("Id");

create table "Concepto"
(
    "Id"             serial
        constraint concepto_pk
            primary key,
    "IdVenta"        integer not null
        constraint venta___fk
            references "Venta",
    "Cantidad"       integer not null,
    "PrecioUnitario" numeric not null,
    "Importe"        numeric not null,
    "IdProduct"      integer not null
        constraint product___fk
            references "Producto"
);

alter table "Concepto"
    owner to postgres;

create unique index concepto_id_uindex
    on "Concepto" ("Id");

create unique index cliente_id_uindex
    on "Cliente" ("Id");