CREATE DATABASE MovieDB;

CREATE SCHEMA MovieSchema;

CREATE TABLE genre(
    code char(3) not null ,
    name varchar(32) not null,
    description varchar(128),

    Constraint genre_pk PRIMARY KEY (Code)
);

CREATE TABLE movie(
    id integer not null ,
    title varchar(128) not null,
    year integer not null,
    length interval not null,
    audience_rating real not null,
    image_file_path varchar(128) not null,

    Constraint movie_pk PRIMARY KEY (id)
);

CREATE TABLE member_type(
    id integer not null ,
    name varchar(32) not null,
    description varchar(128) not null,

    Constraint member_type_pk PRIMARY KEY (id)
);

CREATE TABLE jt_movie_member(
    movie_id integer not null ,
    member_id integer not null,

    Constraint jt_movie_member_pk PRIMARY KEY (member_id, movie_id),

    CONSTRAINT member_fk FOREIGN KEY (member_id)
    REFERENCES member (id) ON DELETE RESTRICT ON UPDATE CASCADE,

    CONSTRAINT movie_fk FOREIGN KEY (movie_id)
    REFERENCES movie (id) ON DELETE RESTRICT ON UPDATE CASCADE
);

CREATE TABLE member(
    id integer not null ,
    name varchar(128) not null,
    date_of_birth date not null ,
    member_type_id integer not null,

    Constraint member_pk PRIMARY KEY (id),

    CONSTRAINT member_fk FOREIGN KEY (member_type_id)
    REFERENCES member_type (id) ON DELETE RESTRICT ON UPDATE CASCADE
);

CREATE TABLE jt_genre_movie(
    genre_code char(3) not null ,
    movie_id integer not null,

    Constraint jt_genre_movie_pk PRIMARY KEY (genre_code, movie_id),

    CONSTRAINT jt_genre_fk FOREIGN KEY (genre_code)
    REFERENCES Genre (Code) ON DELETE RESTRICT ON UPDATE CASCADE,

    CONSTRAINT jt_movie_fk FOREIGN KEY (movie_id)
    REFERENCES movie (id) ON DELETE RESTRICT ON UPDATE CASCADE
);