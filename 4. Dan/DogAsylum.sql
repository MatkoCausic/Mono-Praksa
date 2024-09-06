DROP TABLE IF EXISTS "Dog";
DROP TABLE IF EXISTS "Asylum";

CREATE TABLE "Asylum"(
"Id" uuid DEFAULT gen_random_uuid() PRIMARY KEY,
"Name" VARCHAR NOT NULL,
"Address" VARCHAR NOT NULL,
"PhoneNumber" VARCHAR
);
CREATE TABLE "Dog"(
"Id" uuid DEFAULT gen_random_uuid() PRIMARY KEY,
"Name" VARCHAR,
"Age" INT,
"FurColor" VARCHAR,
"IsTrained" BOOL,
"AsylumId" uuid,
CONSTRAINT "FK_Dog_Asylum_AsylumId"
	FOREIGN KEY("AsylumId")
		REFERENCES "Asylum"("Id")
);

INSERT INTO "Asylum" ("Name","Address","PhoneNumber")
VALUES
	('Sapica','Slatinska 10','1234');

SELECT * FROM "Asylum";

INSERT INTO "Dog" ("Name","Age","FurColor","IsTrained","AsylumId")
VALUES
	('Edgar',11,'Blonde',true,(SELECT "Id" FROM "Asylum" WHERE "Name" = 'Sapica')),
	('Kala',2,'Brown',false,NULL),
	('Deni',14,'White',true,NULL);

UPDATE "Dog"
SET "IsTrained" = true
WHERE "IsTrained" = false AND "Name" = 'Kala';

SELECT * FROM "Dog";8d32e32e-3cc8-4c01-a158-31674ca57392