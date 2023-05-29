<div align="center">

### Travel Agents API

</div>

#API Definition

### Create Admin Request

```csharp
[Authorize(Roles = "Admin")]
```

```js
POST / admin;
```

```json
{
  "Username": "",
  "FirstName": "",
  "LastName": "",
  "Email": "test@gmail.com",
  "Password": "yfgfgf#257",
  "ConfirmPassword": "yfgfgf#257",
  "Date of Birth": "2022-05-08T08:00:00"
}
```

### Created Admin Response

```js
201 Created
```

```yml
Location: {{host}}/admin/{{id}}
```

```json
{
  "Id": "00000000-0000-0000-0000-000000000000",
  "First Name": "Jason",
  "Last Name": "Asare",
  "Age": "23",
  "Username": "jayso",
  "NormalizedUserName": "JAYSO",
  "Email": "test@gmail.com",
  "NormalizedEmail": "TEST@GMAIL.COM",
  "EmailConfirmed": "TRUE",
  "PasswordHash": "feasfdasfadsfsaf22@@",
  "PasswordSalt": ""
  "CreatedDateTime": "2022-04-08T08:00:00",
  "SecurityStamp": "asfdsafsadfdasfadsfadsfdsafdsafGAd@12322",
  "ConcurrencyStamp": "00000000-0000-0000-0000-000000000000",
  "PhoneNumber": "321321321312",
  "PhoneNumberConfirmed": "FALSE",
  "TwoFactorEnabled": "FALSE",
  "LockoutEnd": "5/1/2023 8:06:32 AM +01:00",
  "LockoutEnabled": "FALSE",
  "AccessFailedCount": "0"
}
```

## Get Admin

### Get Admin Request

```csharp
[Authorize(Roles = "Admin")]
```

```js
GET admin/{{id}}
```

### Get Admin Response

```js
200 OK
```

```json
{
  "Id": "00000000-0000-0000-0000-000000000000",
  "FirstName": "Jason",
  "LastName": "Asare",
  "Age": "23",
  "Username": "jayso",
  "NormalizedUserName": "JAYSO",
  "Email": "test@gmail.com",
  "NormalizedEmail": "TEST@GMAIL.COM",
  "EmailConfirmed": "TRUE",
  "PasswordHash": "feasfdasfadsfsaf22@@",
  "CreatedDateTime": "2022-04-08T08:00:00",
  "SecurityStamp": "asfdsafsadfdasfadsfadsfdsafdsafGAd@12322",
  "ConcurrencyStamp": "00000000-0000-0000-0000-000000000000",
  "PhoneNumber": "321321321312",
  "PhoneNumberConfirmed": "FALSE",
  "TwoFactorEnabled": "FALSE",
  "LockoutEnd": "5/1/2023 8:06:32 AM +01:00",
  "LockoutEnabled": "FALSE",
  "AccessFailedCount": "0"
}
```

###Create User Request

```js
POST / USER;
```

```json
{
  "Username": "jayso",
  "FirstName": "Jason",
  "LastName": "Asare",
  "Email": "test@gmail.com",
  "Password": "yfgfgf#257",
  "ConfirmPassword": "yfgfgf#257",
  "Date of Birth": "2022-05-08T08:00:00"
}
```

### Created User Response

```js
201 Created
```

```yml
Location: {{host}}/users/{{id}}
```

```json
{
  "Id": "00000000-0000-0000-0000-000000000000",
  "First Name": "Jason",
  "Last Name": "Asare",
  "Age": "23",
  "Username": "jayso",
  "NormalizedUserName": "JAYSO",
  "Email": "test@gmail.com",
  "NormalizedEmail": "TEST@GMAIL.COM",
  "EmailConfirmed": "TRUE",
  "PasswordHash": "feasfdasfadsfsaf22@@",
  "CreatedDateTime": "2022-04-08T08:00:00",
  "SecurityStamp": "asfdsafsadfdasfadsfadsfdsafdsafGAd@12322",
  "ConcurrencyStamp": "00000000-0000-0000-0000-000000000000",
  "PhoneNumber": "321321321312",
  "PhoneNumberConfirmed": "FALSE",
  "TwoFactorEnabled": "FALSE",
  "LockoutEnd": "5/1/2023 8:06:32 AM +01:00",
  "LockoutEnabled": "FALSE",
  "AccessFailedCount": "0"
}
```

## Get User

### Get User Request

```csharp
[Authorize(Role = "User")]
```

```js
GET users/{{id}}
```

### Get User Response

```js
200 OK
```

```json
{
  "Id": "00000000-0000-0000-0000-000000000000",
  "First Name": "Jason",
  "Last Name": "Asare",
  "Age": "23",
  "Username": "jayso",
  "NormalizedUserName": "JAYSO",
  "Email": "test@gmail.com",
  "NormalizedEmail": "TEST@GMAIL.COM",
  "EmailConfirmed": "TRUE",
  "PasswordHash": "feasfdasfadsfsaf22@@",
  "CreatedDateTime": "2022-04-08T08:00:00",
  "SecurityStamp": "asfdsafsadfdasfadsfadsfdsafdsafGAd@12322",
  "ConcurrencyStamp": "00000000-0000-0000-0000-000000000000",
  "PhoneNumber": "321321321312",
  "PhoneNumberConfirmed": "FALSE",
  "TwoFactorEnabled": "FALSE",
  "LockoutEnd": "5/1/2023 8:06:32 AM +01:00",
  "LockoutEnabled": "FALSE",
  "AccessFailedCount": "0"
}
```

##Upsert User

### Upsert User Request

```csharp
[Authorize(Role = "User")]
```

```js
PUT /users/{{id}}
```

```json
{
  "First Name": "Jason",
  "Last Name": "Asare",
  "Age": "23",
  "Username": "jayso",
  "Email": "test@gmail.com"
}
```

### Upserted User Response

```js
200 OK
```

```json
{
  "Id": "00000000-0000-0000-0000-000000000000",
  "First Name": "Jason",
  "Last Name": "Asare",
  "Age": "23",
  "Username": "jayso",
  "NormalizedUserName": "JAYSO",
  "Email": "test@gmail.com",
  "NormalizedEmail": "TEST@GMAIL.COM",
  "EmailConfirmed": "TRUE",
  "PasswordHash": "feasfdasfadsfsaf22@@",
  "CreatedDateTime": "2022-04-08T08:00:00",
  "SecurityStamp": "asfdsafsadfdasfadsfadsfdsafdsafGAd@12322",
  "ConcurrencyStamp": "00000000-0000-0000-0000-000000000000",
  "PhoneNumber": "321321321312",
  "PhoneNumberConfirmed": "FALSE",
  "TwoFactorEnabled": "FALSE",
  "LockoutEnd": "5/1/2023 8:06:32 AM +01:00",
  "LockoutEnabled": "FALSE",
  "AccessFailedCount": "0"
}
```

## Suspend User

### Suspend User Request

```csharp
[Authorize(Roles = "Admin")]
```

## Delete User

### Delete User Request

```csharp
[Authorize(Role = "User")]
```

```js
DELETE /users/{{id}}
```

```json
{
  "Password": "yfgfgf#257"
}
```

### Delete User Response

```js
204 No Content
```

## Create Booking

###Create Booking Request

```csharp
[Authorize(Role = "User")]
```

```js
POST / Bookings;
```

```json
{
  "departureDateTime": "2022-04-08T08:00:00",
  "arrivalDateTime": "2022-05-08T08:00:00",
  "originId": "00000000-0000-0000-0000-000000000000",
  "destinationid": "00000000-0000-0000-0000-000000000000"
}
```

### Created Booking Response

```js
201 Created
```

```yml
Location: {{host}}/Booking/{{id}}
```

```json
    "Id": "00000000-0000-0000-0000-000000000000",
    "CreatedDateTime": "2022-04-08T08:00:00",
    "LastModifiedDateTime": "2022-04-08T08:00:00",
    "departureDateTime": "2022-04-08T08:00:00",
    "arrivalDateTime": "2022-05-08T08:00:00",
    "trip":
    {
        "origin":
        {
            "Id": "00000000-0000-0000-0000-000000000000",
            "Country": "Ghana",
            "City": "Accra",
            "Price": "1921.23"
        },
        "destinations":
        {
            "Id": "00000000-0000-0000-0000-000000000000",
            "City": "Accra",
            "Country": "Ghana",
            "Rating" : "4.7",
            "Destination": " capital and largest city of Ghana, on the Gulf of Guinea (an arm of the Atlantic Ocean)..",
            "BasePrice": "1253.21"
        }
    }
```

## Upsert Booking

```csharp
[Authorize(Role = "User")]
```

### Upsert Booking Request

```js
PUT /bookings/{{id}}
```

```json
{
  "departureDateTime": "2022-04-08T08:00:00",
  "arrivalDateTime": "2022-05-08T08:00:00",
  "originId": "00000000-0000-0000-0000-000000000000",
  "destinationid": "00000000-0000-0000-0000-000000000000"
}
```

### Upsert Booking Response

```js
200 OK
```

```yml
Location: {{localhost}}/bookings/{{id}}
```

```json
{
  "Id": "00000000-0000-0000-0000-000000000000",
    "CreatedDateTime": "2022-04-08T08:00:00",
    "LastModifiedDateTime": "2022-04-08T08:00:00",
    "departureDateTime": "2022-04-08T08:00:00",
    "arrivalDateTime": "2022-05-08T08:00:00",
    "totalCost": "3,174.44",
    "Discount" : "00.00"
    "trip" : {
        "origin":
        {
            "Id": "00000000-0000-0000-0000-000000000000",
            "Country": "Ghana",
            "City": "Accra",
            "Price": "1921.23"
        },
        "destinations":
        {
            "Id": "00000000-0000-0000-0000-000000000000",
            "City": "Accra",
            "Country": "Ghana",
            "Rating" : "4.7",
            "Destination": " capital and largest city of Ghana, on the Gulf of Guinea (an arm of the Atlantic Ocean)..",
            "BasePrice": "1253.21"
        }
  }
}
```

## Delete Booking

```csharp
[Authorize(Role = "User")]
```

### Delete Booking Request

```js
POST /bookings/{{id}}
```

### Delete Booking Response

```js
200 OK
```

```json
{
  "cancellationCost": "100.00"
}
```

## Create Origin

### Create Origin Request

```csharp
[Authorize(Roles = "Admin")]
```

```js
POST / origin;
```

```json
{
  "Country": "Ghana",
  "City": "Accra",
  "Price": "1921.23"
}
```

### Create Origin Response

```yml
Location: {{host}}/origins/{{id}}
```

```js
201 Created
```

```json
{
  "Id": "00000000-0000-0000-0000-000000000000",
  "Country": "Ghana",
  "City": "Accra",
  "Price": "1921.23",
  "CreatedDateTime": "2022-04-08T08:00:00",
  "LastModifiedDateTime": "2022-04-08T08:00:00"
}
```

## Get Origin

### Get Origin Request

```csharp
[Authorize(Roles = "Admin")]
```

```js
GET /origins/{{id}}
```

### Get Origin Response

```js
200 OK
```

```json
{
  "Id": "00000000-0000-0000-0000-000000000000",
  "Country": "Ghana",
  "City": "Accra",
  "Price": "1921.23",
  "CreatedDateTime": "2022-04-08T08:00:00",
  "LastModifiedDateTime": "2022-04-08T08:00:00"
}
```

##Upsert Origin

### Upsert Origin Request

```csharp
[Authorize(Roles = "Admin")]
```

```js
PUT /origins/{{id}}
```

```json
{
  "Country": "Ghana",
  "City": "Accra",
  "Price": "1921.23"
}
```

### Upsert Origin Response

```js
200 OK
```

```yml
Location: {{localhost}}/origins/{{id}}
```

```json
{
  "Id": "00000000-0000-0000-0000-000000000000",
  "Country": "Ghana",
  "City": "Accra",
  "Price": "1921.23",
  "CreatedDateTime": "2022-04-08T08:00:00",
  "LastModifiedDateTime": "2022-04-08T08:00:00"
}
```

## Delete Origin

### Delete Origin Request

```csharp
[Authorize(Roles = "Admin")]
```

```js
DELETE /origins/{{id}}
```

### Delete Origin Response

```js
204 No Content
```

## Create Destination

### Create Destination Request

```csharp
[Authorize(Roles = "Admin")]
```

```js
POST / destinations;
```

```json
{
  "Country": "Ghana",
  "City": "Accra",
  "Price": "1921.23",
  "Destination": " capital and largest city of Ghana, on the Gulf of Guinea (an arm of the Atlantic Ocean).."
}
```

### Create Destination Response

```yml
Location: {{localhost}}/destinations/{{id}}
```

```json
{
  "Id": "00000000-0000-0000-0000-000000000000",
  "City": "Accra",
  "Country": "Ghana",
  "Rating": "4.7",
  "Destination": " capital and largest city of Ghana, on the Gulf of Guinea (an arm of the Atlantic Ocean)..",
  "BasePrice": "1253.21"
}
```

## Upsert Destination

### Upsert Destination Request

```csharp
[Authorize(Role = "Admin")]
```

```js
PUT /destinations/{{id}}
```

```json
{
  "Country": "Ghana",
  "City": "Accra",
  "Price": "1921.23",
  "Description": " capital and largest city of Ghana, on the Gulf of Guinea (an arm of the Atlantic Ocean).."
}
```

### Upsert Destination Response

```js
200 OK
```

```yml
Location: {{localhost}}/destinations/{{id}}
```

```json
{
  "Id": "00000000-0000-0000-0000-000000000000",
  "City": "Accra",
  "Country": "Ghana",
  "Rating": "4.7",
  "Description": " capital and largest city of Ghana, on the Gulf of Guinea (an arm of the Atlantic Ocean)..",
  "BasePrice": "1253.21"
}
```
