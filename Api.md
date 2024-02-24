# Arth Product API

- [Arth Product API](#arth-product-api)
  - [Create Product](#create-product)
    - [Create Product Request](#create-product-request)
    - [Create Product Response](#create-product-response)
  - [Get Product](#get-product)
    - [Get Product Request](#get-product-request)
    - [Get Product Response](#get-product-response)
  - [Update Product](#update-product)
    - [Update Product Request](#update-product-request)
    - [Update Product Response](#update-product-response)
  - [Delete Product](#delete-product)
    - [Delete Product Request](#delete-product-request)
    - [Delete Product Response](#delete-product-response)

## Create Product

### Create Product Request

```js
POST /products
```

```json
{
    "name": "Full Lunch",
    "description": "The best of Brazilian cuisine",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "savory": [
        "Feijoada",
        "Feijão Tropeiro",
        "Vaca Atolada",
        "Frango com Quiabo"
    ],
    "Sweet": [
        "Doce de Leite"
    ]
}
```

### Create Product Response

```js
201 Created
```

```yml
Location: {{host}}/Products/{{id}}
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Full Lunch",
    "description": "The best of Brazilian cuisine",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "lastModifiedDateTime": "2022-04-06T12:00:00",
    "savory": [
        "Feijoada",
        "Feijão Tropeiro",
        "Vaca Atolada",
        "Frango com Quiabo"
    ],
    "Sweet": [
        "Doce de Leite"
    ]
}
```

## Get Product

### Get Product Request

```js
GET /products/{{id}}
```

### Get Product Response

```js
200 Ok
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Full Lunch",
    "description": "The best of Brazilian cuisine",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "lastModifiedDateTime": "2022-04-06T12:00:00",
    "savory": [
        "Feijoada",
        "Feijão Tropeiro",
        "Vaca Atolada",
        "Frango com Quiabo"
    ],
    "Sweet": [
        "Doce de Leite"
    ]
}
```

## Update Product

### Update Product Request

```js
PUT /products/{{id}}
```

```json
{
    "name": "Full Lunch",
    "description": "The best of Brazilian cuisine",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "savory": [
        "Feijoada",
        "Feijão Tropeiro",
        "Vaca Atolada",
        "Frango com Quiabo"
    ],
    "Sweet": [
        "Doce de Leite"
    ]
}
```

### Update Product Response

```js
204 No Content
```

or

```js
201 Created
```

```yml
Location: {{host}}/Products/{{id}}
```

## Delete Product

### Delete Product Request

```js
DELETE /products/{{id}}
```

### Delete Product Response

```js
204 No Content
```