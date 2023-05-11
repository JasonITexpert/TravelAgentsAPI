<div align="center">

### Travel Agents API

</div>

#API Definition

###Create Booking Request

```js
POST / Booking;
```

```yml
Location: {{host}}/booking/{{id}}
```

```JSON
{
    "departureDateTime": "2022-04-08T08:00:00",
    "arrivalDateTime": "2022-05-08T08:00:00"
    "destination": "00000000-0000-0000-0000-000000000000"
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
    "departureDateTime": "2022-04-08T08:00:00",
    "arrivalDateTime": "2022-05-08T08:00:00"
    "destination":
    [
        "Id": "00000000-0000-0000-0000-000000000000",
        "Destination": "Accra",
        "Country": "Ghana",
        "Rating" : "4.7",
        "Destination": " capital and largest city of Ghana, on the Gulf of Guinea (an arm of the Atlantic Ocean)..",
        "BasePrice": "1253.21"
    ]
```
