﻿namespace Arth.Contracts.Menus;

public record MenuResponse(
    string Id,
    string Name,
    string Description,
    float? AverageRating,
    List<MenuSectionResponse> Sections,
    string HostId,
    List<string>LunchIds,
    List<string> MenuReviewIds,
    DateTime CreatedDateTime,
    DateTime UpdatedDateTime);

public record MenuSectionResponse(
    string Id,
    string Name,
    string Description,
    float? AverageRating,
List<MenuItemResponse> Sections);

public record MenuItemResponse(
    string Id,
    string Name,
    string Description,
    float? AverageRating,
List<MenuItemResponse> Sections);

