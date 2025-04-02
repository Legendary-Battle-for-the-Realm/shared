# API DOCUMENT
## Authentication (Đăng Ký & Đăng Nhập)
1. Đăng Ký (Register)
- Endpoint: **POST** **/api/auth/register**
- Mô tả: Tạo tài khoản người chơi mới.
- Request Body:
```json
{
    "username": "player123",
    "password": "YourSecurePassword",
    "email": "player123@example.com"
}
```
- Response (Success):
```json
{
    "status": "success",
    "message": "Đăng ký thành công.",
    "player": {
        "id": "player_123",
        "username": "player123"
    }
}
```
- Response (Error):
```json
{
    "status": "error",
    "message": "Tên người dùng/Email đã tồn tại."
}
```
2. Đăng Nhập (Login)
- Endpoint: **POST** **/api/auth/login**
- Mô tả: Xác thực tài khoản người chơi và cấp token truy cập.
- Request Body:
```json
{
    "username": "player123",
    "password": "YourSecurePassword"
}
```
- Response (Success):
```json
{
    "status": "success",
    "message": "Đăng nhập thành công.",
    "token": "jwt-token-here",
    "player": {
        "id": "player_123",
        "username": "player123"
    }
}
```
- Response (Error):
```json
{
    "status": "error",
    "message": "Thông tin đăng nhập không chính xác."
}
```
## Connection (Kết Nối)
- Direction: Client → Server (qua WebSocket)
- Action: "connect"
- Purpose: Gửi thông tin người chơi (đã được xác thực) tới server.
- Request JSON:
```json
{
    "action": "connect",
    "player": { "id": "player_123", "name": "Người chơi A" }
}
```
- Response (Connect Ack): Server gửi lại thông qua message "connect_ack".
## Match Initialization (Khởi Tạo Trận Đấu)
1. InitMatch
- Direction: Client → Server
- Action: "init_match"
- Purpose: Yêu cầu bắt đầu trận đấu với danh sách người chơi.
- Request JSON:
```json
{
    "action": "init_match",
    "data": {
        "players": ["player_123", "player_456", "player_789"]
    }
}
```
2. MatchStarted
- Direction: Server → Client
- Action: "match_started"
- Purpose: Thông báo rằng trận đấu đã bắt đầu, kèm theo thông tin khởi tạo trận đấu.
- Response JSON:
```json
{
    "action": "match_started",
    "data": {
        "players": [
            { "id": "player_123", "name": "Người chơi A" },
            { "id": "player_456", "name": "Người chơi B" },
            { "id": "player_789", "name": "Người chơi C" }
        ],
        "order": ["player_456", "player_123", "player_789"],
        "characterCards": [
            {
                "id": 0,
                "name": "Lý Vô Song",
                "desc": "Kiếm khách lạnh lùng đến từ Võ Đang.",
                "atk": 85,
                "faction": "Võ Đang",
                "skill": [
                    { "name": "Thái Cực Kiếm", "ref": "vo_dang_sword" }
                ]
            }
        ]
    }
}
```
## Turn Actions (Thao Tác Trong Lượt)
1. DrawCard
- Direction: Client → Server
- Action: "draw_card"
- Purpose: Yêu cầu bốc bài cho người chơi.
- Request JSON:
```json
{
    "action": "draw_card",
    "playerId": "player_123"
}
```
2. CardDrawn
- Direction: Server → Client
- Action: "card_drawn"
- Purpose: Thông báo các lá bài đã được bốc.
- Response JSON:
```json
{
    "action": "card_drawn",
    "playerId": "player_123",
    "data": {
        "cards": [
            { "value": 5, "suit": "Hearts" },
            { "value": 13, "suit": "Diamonds" }
        ]
    }
}
```
(hành động khác có thể được thêm sau)
## State Update (Cập Nhật Trạng Thái)
- Direction: Server → Client
- Action: "update_state"
- Purpose: Cập nhật trạng thái sau mỗi hành động (HP, buffs, trang bị,...).
- Response JSON:
```json
{
    "action": "update_state",
    "data": {
        "playerId": "player_123",
        "hp": 80,
        "buffs": [
            { "name": "Tăng HP", "ref": "increase_hp" }
        ]
    }
}
```
## Turn/Match End (Kết Thúc Lượt/Trận Đấu)
1. EndTurn
- Direction: Server → Client
- Action: "end_turn"
- Purpose: Thông báo kết thúc lượt hiện tại và chuyển lượt cho người chơi tiếp theo.
- Response JSON:
```json
{
    "action": "end_turn",
    "data": {
        "playerId": "player_123"
        // Có thể thêm thông tin khác như điểm, trạng thái cuối lượt,...
    }
}
```
2. MatchEnd
- Direction: Server → Client
- Action: "match_end"
- Purpose: Thông báo kết thúc trận đấu, kèm theo thông tin người chiến thắng và các kết quả cuối cùng.
- Response JSON:
```json
{
    "action": "match_end",
    "data": {
        "winnerPlayerId": "player_456"
        // Thông tin bổ sung: bảng xếp hạng, điểm số, v.v.
    }
}
```