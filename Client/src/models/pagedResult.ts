export class PagedResult<Type> {
    totalPages?: number;
    itemsFrom?: number;
    itemsTo?: number;
    totalItems?: number;
    itemsList?: Type;
}